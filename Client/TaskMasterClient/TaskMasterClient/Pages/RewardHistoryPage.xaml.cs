using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class RewardHistoryPage : ContentPage
{
    public RewardHistoryPage()
    {
        InitializeComponent();
        Title = "Reward History";
        BindingContext = new RewardHistoryViewModel();
    }
}