using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class PartnersPage : BasePage
{
    public PartnersPage()
    {
        InitializeComponent();
        Title = "Partners";
        BindingContext = new PartnersViewModel();
    }
}