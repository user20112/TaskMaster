using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
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