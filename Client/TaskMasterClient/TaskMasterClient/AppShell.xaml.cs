using TaskMasterClient.Pages;
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

        private async void OnChatTapped(object sender, EventArgs e)
        {
            await Shell.Current.CurrentPage.Navigation.PushAsync(new ChatPage());
        }

        private async void onPartnerTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.CurrentPage.Navigation.PushAsync(new PartnersPage());
        }
    }
}