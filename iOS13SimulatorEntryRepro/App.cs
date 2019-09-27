using Xamarin.Forms;

namespace iOS13SimulatorEntryRepro
{
    public class App : Application
    {
        public App() => MainPage = new EntryPage();

        class EntryPage : ContentPage
        {
            public EntryPage()
            {
                var stackLayout = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(20),

                    Children =
                    {
                        new Entry { Placeholder = "Tap this entry to crash the app" },
                        new Editor { Placeholder = "Tap this editor to crash the app" }
                    }
                };

                stackLayout.CompressAllLayouts();

                Content = stackLayout;
            }
        }
    }
}
