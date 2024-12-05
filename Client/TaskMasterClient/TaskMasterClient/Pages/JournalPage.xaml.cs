using TaskMasterClient.ViewModels;

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