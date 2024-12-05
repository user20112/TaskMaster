using CoreGraphics;
using Foundation;
using UIKit;

namespace TaskMasterClient
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var statusBarColor = (Color)Microsoft.Maui.Controls.Application.Current!.Resources["Tertiary"];

            // Create a UIView and set its background color to the desired status bar color
            var statusBarView = new UIView(GetStatusBarFrame())
            {
                BackgroundColor = ToPlatformColor(statusBarColor)
            };
            Window!.AddSubview(statusBarView);
            Window!.BringSubviewToFront(statusBarView);
            return base.FinishedLaunching(app, options);
        }
        public CGRect GetStatusBarFrame()
        {
            CGRect statusBarFrame;

            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                // For iOS 13 and later, use StatusBarManager
                var window = UIApplication.SharedApplication.Windows.FirstOrDefault();
                if (window != null && window.WindowScene != null)
                {
                    var statusBarManager = window.WindowScene.StatusBarManager;
                    if (statusBarManager != null)
                        statusBarFrame = statusBarManager.StatusBarFrame;
                    else
                        statusBarFrame = CGRect.Empty;
                }
                else
                    statusBarFrame = CGRect.Empty;
            }
            else
                statusBarFrame = UIApplication.SharedApplication.StatusBarFrame;
            return statusBarFrame;
        }
        public static UIColor ToPlatformColor(Color color)
        {
            return new UIColor((nfloat)color.Red, (nfloat)color.Green, (nfloat)color.Blue, (nfloat)color.Alpha);
        }
    }
}