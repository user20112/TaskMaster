using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class AboutPage : BasePage
{
    public AboutPage()
    {
        InitializeComponent();
        Title = "About";
        BindingContext = new AboutViewModel();
    }
}