using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		Title = "Login";
        BindingContext = new LoginViewModel();
    }
}