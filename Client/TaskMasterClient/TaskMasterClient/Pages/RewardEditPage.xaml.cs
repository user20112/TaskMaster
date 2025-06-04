using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class RewardEditPage : BasePage
{
    public RewardEditPage()
    {
        InitializeComponent();
        BindingContext = new RewardEditViewModel();
    }
}