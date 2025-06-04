using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels.Pages;

namespace TaskMasterClient.Pages;

public partial class WeeklySummaryPage : BasePage
{
    public WeeklySummaryPage()
    {
        InitializeComponent();
        Title = "Weekly Summary";
        BindingContext = new WeeklySummaryViewModel();
    }
}