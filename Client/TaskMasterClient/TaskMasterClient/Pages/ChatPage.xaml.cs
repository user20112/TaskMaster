using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

using TaskMasterClient.ViewModels.Pages;
namespace TaskMasterClient.Pages;

public partial class ChatPage : BasePage
{
    public ChatPage()
    {
        InitializeComponent();
        Title = "Chat";
        BindingContext = new ChatViewModel();
    }
}