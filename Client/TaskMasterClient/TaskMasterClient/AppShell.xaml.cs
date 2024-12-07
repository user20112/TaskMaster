using TaskMasterClient.ViewModels;

namespace TaskMasterClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new AppShellViewModel()
            {
                IsBusy = false,
                PartnerName = "August",
                PartnerRole = "Submissive",
                PartnersProfileImage = "profilepicture.png"
            };
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);
        }

        private void OnChatTapped(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Chat image clicked!");
        }
    }
}