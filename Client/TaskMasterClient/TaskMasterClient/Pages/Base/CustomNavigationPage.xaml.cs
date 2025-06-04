using Microsoft.Maui.Graphics.Text;

namespace TaskMasterClient.Pages.Base;

public partial class CustomNavigationPage : NavigationPage
{
	public CustomNavigationPage()
	{
		InitializeComponent();
	}

    public CustomNavigationPage(Page root) : base(root)
    {
        InitializeComponent();
    }
}