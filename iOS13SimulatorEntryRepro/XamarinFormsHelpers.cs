﻿using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace iOS13SimulatorEntryRepro
{
    public static class XamarinFormsHelpers
    {
        public static void CompressAllLayouts(this Layout<View> layout)
        {
            var childLayouts = GetChildLayouts(layout);

            foreach (var childLayout in childLayouts)
                CompressAllLayouts(childLayout);

            if (layout.BackgroundColor == default && !layout.GestureRecognizers.Any())
                CompressedLayout.SetIsHeadless(layout, true);
        }

        public static void CancelAllAnimations(VisualElement element)
        {
            switch (element)
            {
                case ContentView contentView:
                    CancelAllAnimations(contentView.Content);
                    break;

                case Layout<View> layout:
                    var childLayoutsOfLayout = GetChildLayouts(layout);

                    foreach (var childLayout in childLayoutsOfLayout)
                        CancelAllAnimations(childLayout);

                    foreach (var view in layout.Children)
                        CancelAllAnimations(view);
                    break;

                case View view:
                    ViewExtensions.CancelAnimations(view);
                    break;
            }
        }

        static IEnumerable<Layout<View>> GetChildLayouts(in Layout<View> layout)
        {
            if (layout.Children is null || !layout.Children.Any())
                return Enumerable.Empty<Layout<View>>();

            var childLayouts = layout.Children.OfType<Layout<View>>();

            var childContentViews = layout.Children.OfType<ContentView>();
            var childContentViewLayouts = childContentViews.Select(x => x.Content).OfType<Layout<View>>();

            return childLayouts.Concat(childContentViewLayouts);
        }
    }
}

