using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class LoginPage : BasePage
{
	public LoginPage()
	{
		InitializeComponent();
		Title = "Login";
        BindingContext = new LoginViewModel();
    }
    public void OnLoginButtonClicked(object sender, EventArgs e)
    {
        (BindingContext as LoginViewModel).OnLogin(NicknameEntry.Text, PasswordEntry.Text);
    }
    public void OnResetPasswordButtonClicked(object sender, EventArgs e)
    {
        (BindingContext as LoginViewModel).OnResetPassword(NicknameEntry.Text);
    }
    public void OnEditImageTapped(object sender, EventArgs e)
    {
        (BindingContext as LoginViewModel).OnEditImageTapped(NicknameEntry.Text);
    }
}