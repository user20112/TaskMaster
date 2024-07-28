using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
		Title = "About";
        BindingContext = new AboutPageViewModel();
    }
}