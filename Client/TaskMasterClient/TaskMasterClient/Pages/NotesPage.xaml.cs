using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class NotesPage : ContentPage
{
    public NotesPage()
    {
        InitializeComponent();
        Title = "Notes";
        BindingContext = new NotesViewModel();
    }
}