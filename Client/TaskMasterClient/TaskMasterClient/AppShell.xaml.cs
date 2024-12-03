using System.Collections.ObjectModel;

namespace TaskMasterClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);
            pageTitle.Text = Current.CurrentPage.Title;
        }
    }
}
