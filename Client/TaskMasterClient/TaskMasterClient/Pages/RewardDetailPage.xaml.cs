using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class RewardDetailPage : ContentPage
{
	public RewardDetailPage()
	{
		InitializeComponent();
		BindingContext= new RewardDetailViewModel();
    }
}