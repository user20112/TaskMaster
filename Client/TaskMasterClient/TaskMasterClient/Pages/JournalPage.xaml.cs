using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class JournalPage : BasePage
{
    public JournalPage()
    {
        InitializeComponent();
        Title = "Journal";
        BindingContext = new JournalViewModel();
    }
}