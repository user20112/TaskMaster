namespace TaskMasterClient.ViewModels
{
    public class SelectImageViewModel : BaseViewModel
    {
        public Action<string> OnImageSelected { get; set; }
        private string _titleText;

        public string TitleText
        {
            get => _titleText;
            set
            {
                if (_titleText != value)
                {
                    _titleText = value;
                    OnPropertyChanged(nameof(TitleText));
                }
            }
        }
    }
}