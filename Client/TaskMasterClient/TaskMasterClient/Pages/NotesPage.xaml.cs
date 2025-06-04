using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class NotesPage : BasePage
{
    public NotesPage()
    {
        InitializeComponent();
        Title = "Notes";
        BindingContext = new NotesViewModel();
    }
}