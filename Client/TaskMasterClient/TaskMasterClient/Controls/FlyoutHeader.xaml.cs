using CommunityToolkit.Maui.Views;
using TaskMasterClient.Popups;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Controls;

public partial class FlyoutHeader : ContentView
{
    public FlyoutHeader()
    {
        InitializeComponent();
        BindingContext = new FlyoutHeaderViewModel()
        {
            ProfileImageSource = "profilepicture.png"
        };
    }

    private void OnProfileImageTapped(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Profile image clicked!");
    }

    private async void OnEditImageTapped(object sender, EventArgs e)
    {
        var popup = new SelectImagePopup("Select Profile Picture", (string selectedFile) =>
        {
            (BindingContext as FlyoutHeaderViewModel)!.OnProfilePictureSelected(selectedFile);
        });
        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
    }
}