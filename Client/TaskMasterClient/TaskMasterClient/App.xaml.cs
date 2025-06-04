using TaskMasterClient.Interfaces;
using TaskMasterClient.Pages;
using TaskMasterClient.Pages.Base;
using TaskMasterClient.Services;

namespace TaskMasterClient;

public partial class App : Application
{
    public static INavigationService NavigationService;
    public static AppSettingsService AppSettingsService;
    public App()
    {
        InitializeServices();
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        if (this.MainPage == null)
        {
            this.MainPage = NavigationService.Init<MainFlyoutPage>();
        }
        var window = base.CreateWindow(activationState);
        const int newWidth = 350;
        const int newHeight = 700;
        window.Width = newWidth;
        window.Height = newHeight;
        window.MaximumHeight = newHeight;
        window.MaximumWidth = newWidth;
        return window;
    }
    public void InitializeServices()
    {
        NavigationService = new NavigationService();
        AppSettingsService = new AppSettingsService();
    }
}