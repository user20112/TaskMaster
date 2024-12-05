using TaskMasterClient.ViewModels;

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