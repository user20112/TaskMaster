
namespace TaskMasterClient.ViewModels
{
    public class FlyoutHeaderViewModel : BaseViewModel
    {
        private string _profileImageSource;

        public string ProfileImageSource
        {
            get => _profileImageSource;
            set
            {
                if (_profileImageSource != value)
                {
                    _profileImageSource = value;
                    OnPropertyChanged(nameof(ProfileImageSource));
                }
            }
        }

        internal void OnProfilePictureSelected(string selectedFile)
        {
            throw new NotImplementedException();
        }
    }
}