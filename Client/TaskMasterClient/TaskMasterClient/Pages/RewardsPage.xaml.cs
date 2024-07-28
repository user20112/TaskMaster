using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class RewardsPage : ContentPage
{
	public RewardsPage()
	{
		InitializeComponent();
        Title = "Rewards";
        BindingContext = new RewardsPageViewModel();
    }
}