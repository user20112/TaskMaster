using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class ChatPage : ContentPage
{
    public ChatPage()
    {
        InitializeComponent();
        Title = "Chat";
        BindingContext = new ChatViewModel();
    }
}