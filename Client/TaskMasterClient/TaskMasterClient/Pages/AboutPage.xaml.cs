using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        Title = "About";
        BindingContext = new AboutViewModel();
    }
}