using CommunityToolkit.Maui.Views;
using TaskMasterClient.Pages.Base;
using TaskMasterClient.Popups;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class ProfilePage : BasePage
{
    public ProfilePage()
    {
        InitializeComponent();
        Title = "Profile";
        BindingContext = new ProfileViewModel();
    }
    private void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        (BindingContext as ProfileViewModel).OnLogout();
    }
    private void OnDeleteAccountButtonClicked(object sender, EventArgs e)
    {
        (BindingContext as ProfileViewModel).OnDelete();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        (BindingContext as ProfileViewModel).OnSave(NickNameEntry.Text,EmailEntry.Text);
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