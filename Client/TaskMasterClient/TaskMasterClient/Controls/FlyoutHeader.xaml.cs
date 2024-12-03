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
    private void OnEditImageTapped(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Edit image clicked!");
    }
}