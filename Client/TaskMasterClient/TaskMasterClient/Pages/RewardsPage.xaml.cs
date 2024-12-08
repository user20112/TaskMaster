using TaskMasterClient.ViewClasses;
using TaskMasterClient.ViewModels;
using TaskMasterClient.ViewModels.Pages;

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
        ((RewardsViewModel)BindingContext)!.PurchaseReward(button?.BindingContext as RewardViewModel);
    }

    private void rewardTapped(object sender, TappedEventArgs e)
    {
        ((RewardsViewModel)BindingContext)!.ViewDetail(button?.BindingContext as RewardViewModel);
    }
}