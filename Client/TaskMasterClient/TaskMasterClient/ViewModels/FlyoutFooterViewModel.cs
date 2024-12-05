namespace TaskMasterClient.ViewModels
{
    internal class FlyoutFooterViewModel : BaseViewModel
    {
        private string _version;

        public string Version
        {
            get => _version;
            set
            {
                if (_version != value)
                {
                    _version = value;
                    OnPropertyChanged(nameof(Version));
                }
            }
        }
    }
}