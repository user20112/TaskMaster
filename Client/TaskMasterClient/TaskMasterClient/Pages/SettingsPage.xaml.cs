using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        Title = "Settings";
        BindingContext = new SettingsViewModel();
    }
}