using CommunityToolkit.Maui.Views;
using TaskMasterClient.Popups;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
        Title = "Profile";
        BindingContext = new ProfileViewModel();
    }
    private void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Lougout clicked!");
    }
    private void OnResetPasswordButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("reset password clicked!");
    }
    private void OnDeleteAccountButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Delete button clicked!");
    }

    private async void OnEditImageTapped(object sender, EventArgs e)
    {
        var popup = new SelectImagePopup("Select Profile Picture", (string selectedFile) =>
        {
            ((ProfileViewModel)BindingContext)!.OnProfilePictureSelected(selectedFile);
        });
        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
    }
}