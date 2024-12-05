using CommunityToolkit.Maui.Views;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Popups
{
    public partial class SelectImagePopup : Popup
    {

        public SelectImagePopup(string titleText, Action<string> onImageSelected)
        {
            InitializeComponent();
            BindingContext = new SelectImageViewModel()
            {
                TitleText = titleText,
                OnImageSelected = onImageSelected
            };
        }

        private async void OnCloseButtonClicked(object sender, EventArgs e)
        {
            await this.CloseAsync();
        }
    }
}