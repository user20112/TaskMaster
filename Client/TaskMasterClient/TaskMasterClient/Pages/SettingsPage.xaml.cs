using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class SettingsPage : BasePage
{
    public SettingsPage()
    {
        InitializeComponent();
        Title = "Settings";
        BindingContext = new SettingsViewModel();
    }
}