using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class RewardEditPage : ContentPage
{
    public RewardEditPage()
    {
        InitializeComponent();
        BindingContext = new RewardEditViewModel();
    }
}