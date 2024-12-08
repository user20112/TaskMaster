using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class TasksPage : ContentPage
{
    public TasksPage()
    {
        InitializeComponent();
        Title = "Tasks";
        BindingContext = new TasksViewModel();
    }
}