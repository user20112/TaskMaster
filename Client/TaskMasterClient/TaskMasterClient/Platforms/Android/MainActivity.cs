using Android.App;
using Android.Content.PM;
using Android.OS;

namespace TaskMasterClient
{
    [Activity(Theme = "@style/Maui.SplashTheme", LaunchMode = LaunchMode.SingleTask,MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Color statusBarColor = (Color)Microsoft.Maui.Controls.Application.Current!.Resources["Tertiary"];
            Window!.SetStatusBarColor(ToPlatformColor(statusBarColor));
        }

        private static Android.Graphics.Color ToPlatformColor(Color color)
        {
            return new Android.Graphics.Color((byte)(color.Red * 255), (byte)(color.Green * 255), (byte)(color.Blue * 255), (byte)(color.Alpha * 255));
        }
    }
}