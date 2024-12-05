using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages;

public partial class PunishmentsPage : ContentPage
{
    public PunishmentsPage()
    {
        InitializeComponent();
        Title = "Punishments";
        BindingContext = new PunishmentsViewModel();
    }
}