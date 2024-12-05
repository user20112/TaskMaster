using TaskMasterClient.ViewModels;

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