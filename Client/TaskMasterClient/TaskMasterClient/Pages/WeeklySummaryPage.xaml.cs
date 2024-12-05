using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class WeeklySummaryPage : ContentPage
{
    public WeeklySummaryPage()
    {
        InitializeComponent();
        Title = "Weekly Summary";
        BindingContext = new WeeklySummaryViewModel();
    }
}