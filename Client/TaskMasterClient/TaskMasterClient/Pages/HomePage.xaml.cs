using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class HomePage : BasePage
{
    public HomePage()
    {
        InitializeComponent();
        Title = "Home";
        BindingContext = new AboutViewModel();
    }
}