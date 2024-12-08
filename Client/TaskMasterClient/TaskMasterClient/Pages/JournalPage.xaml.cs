using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class JournalPage : ContentPage
{
    public JournalPage()
    {
        InitializeComponent();
        Title = "Journal";
        BindingContext = new JournalViewModel();
    }
}