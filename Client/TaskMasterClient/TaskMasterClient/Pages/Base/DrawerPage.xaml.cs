using TaskMasterClient.ViewModels.Base;

namespace TaskMasterClient.Pages.Base;

public partial class DrawerPage : BasePage
{
    public DrawerPage()
    {
        InitializeComponent();
        BindingContext = new DrawerViewModel();
    }
}