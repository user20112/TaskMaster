using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class TasksPage : BasePage
{
    public TasksPage()
    {
        InitializeComponent();
        Title = "Tasks";
        BindingContext = new TasksViewModel();
    }
}