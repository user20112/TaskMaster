namespace TaskMasterClient.ViewModels.Base
{
    public class DrawerItemViewModel : BaseViewModel
    {
        private string image;
        private string text;
        private Command onTapped;

        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
        public Command OnTapped
        {
            get
            {
                return onTapped;
            }
            set
            {
                onTapped = value;
                OnPropertyChanged(nameof(OnTapped));
            }
        }
    }
}
