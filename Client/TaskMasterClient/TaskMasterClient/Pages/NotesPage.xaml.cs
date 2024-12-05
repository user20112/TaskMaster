using TaskMasterClient.ViewModels;

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