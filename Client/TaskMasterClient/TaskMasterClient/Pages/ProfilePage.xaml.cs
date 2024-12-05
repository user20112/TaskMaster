using CommunityToolkit.Maui.Views;
using TaskMasterClient.Popups;
using TaskMasterClient.ViewModels;

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
        System.Diagnostics.Debug.WriteLine("Profile image clicked!");
    }
    private void OnResetPasswordButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Profile image clicked!");
    }
    private void OnDeleteAccountButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Profile image clicked!");
    }

    private async void OnEditImageTapped(object sender, EventArgs e)
    {
        var popup = new SelectImagePopup("Select Profile Picture", (string selectedFile) =>
        {
            (BindingContext as ProfileViewModel)!.OnProfilePictureSelected(selectedFile);
        });
        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
    }
}