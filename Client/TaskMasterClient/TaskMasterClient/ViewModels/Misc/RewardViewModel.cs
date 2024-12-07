using TaskMasterClient.ViewModels;

namespace TaskMasterClient.ViewClasses
{
    public class RewardViewModel :BaseViewModel
    {
        private string _title;
        private string _description;
        private int _cost;
        private int _owed;
        public RewardViewModel(string title, string description, int cost, int owed)
        {
            _title = title;
            _description = description;
            _cost = cost;
            _owed = owed;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public int Cost
        {
            get => _cost;
            set
            {
                if (_cost != value)
                {
                    _cost = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }
        }

        public int Owed
        {
            get => _owed;
            set
            {
                if (_owed != value)
                {
                    _owed = value;
                    OnPropertyChanged(nameof(Owed));
                }
            }
        }

    }
}
