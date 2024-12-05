using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Controls;

public partial class FlyoutFooter : ContentView
{
    public FlyoutFooter()
    {
        InitializeComponent();
        BindingContext = new FlyoutFooterViewModel()
        {
            Version = "0.0.1"
        };
    }
}