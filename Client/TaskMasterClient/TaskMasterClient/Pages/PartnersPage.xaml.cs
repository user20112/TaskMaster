using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class PartnersPage : ContentPage
{
    public PartnersPage()
    {
        InitializeComponent();
        Title = "Partners";
        BindingContext = new PartnersViewModel();
    }
}