using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class RewardDetailPage : BasePage
{
	public RewardDetailPage()
	{
		InitializeComponent();
		BindingContext= new RewardDetailViewModel();
    }
}