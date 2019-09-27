# iOS 13 Simulator Entry Repro

Repro sample demonstrating a crash when an Editor or Entry is tapped on an iOS 13 Simulator.

Note: This sample runs fine on a physical device running iOS 13.

## Stacktracce

```
System.NullReferenceException: Object reference not set to an instance of an object
  at Xamarin.Forms.Platform.iOS.PageRenderer.GetAccessibilityElements () [0x0009c] in d:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\PageRenderer.cs:71
  at Xamarin.Forms.Platform.iOS.PageContainer.get_AccessibilityElements () [0x00008] in d:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\PageContainer.cs:33
  at Xamarin.Forms.Platform.iOS.PageContainer.AccessibilityElementCount () [0x00000] in d:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\PageContainer.cs:65
  at at (wrapper managed-to-native) UIKit.UIApplication.UIApplicationMain(int,string[],intptr,intptr)
  at UIKit.UIApplication.Main (System.String[] args, System.IntPtr principal, System.IntPtr delegate) [0x00005] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.2.0.42/src/Xamarin.iOS/UIKit/UIApplication.cs:86
  at UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x0000e] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.2.0.42/src/Xamarin.iOS/UIKit/UIApplication.cs:65
  at iOS13SimulatorEntryRepro.iOS.Application.Main (System.String[] args) [0x00000] in /Users/bramin/Projects/iOS13SimulatorEntryRepro/iOS13SimulatorEntryRepro.iOS/Main.cs:7
```