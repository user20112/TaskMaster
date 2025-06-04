using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class RewardHistoryPage : BasePage
{
    public RewardHistoryPage()
    {
        InitializeComponent();
        Title = "Reward History";
        BindingContext = new RewardHistoryViewModel();
    }
}