using TaskMasterClient.ViewClasses;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class RewardsPage : ContentPage
{
    public RewardsPage()
    {
        InitializeComponent();
        Title = "Rewards";
        BindingContext = new RewardsViewModel();
    }
    private void OnBuyButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        (BindingContext as RewardsViewModel)!.PurchaseReward(button?.BindingContext as RewardViewModel);
    }
}