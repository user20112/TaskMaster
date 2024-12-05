using TaskMasterClient.ViewModels;

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