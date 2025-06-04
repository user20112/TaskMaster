using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class PunishmentsPage : BasePage
{
    public PunishmentsPage()
    {
        InitializeComponent();
        Title = "Punishments";
        BindingContext = new PunishmentsViewModel();
    }
}