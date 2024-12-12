using System.Collections.ObjectModel;
using System.ComponentModel;
using TaskMasterClient.ViewClasses;

namespace TaskMasterClient.ViewModels.Pages
{
    internal class RewardsViewModel : BaseViewModel
    {
        private int _rewardPoints;
        private ObservableCollection<RewardViewModel> _rewards;
        public RewardsViewModel()
        {
            // Initialize with some dummy data
            _rewards = new ObservableCollection<RewardViewModel>
            {
                new RewardViewModel("Get some icecream",
                                     "nice sweet treat to start the day",
                                     5, 0),
                new RewardViewModel("have a day out",
                                     "just a happy day out what is there to complain about ?",
                                     10, 1),
                new RewardViewModel("some other treat",
                                     "some other treat, ( ijust need this text box to be longer so im going to keep typeing, maybe its going out to the mall, or getting headpats, or bluey time who knows my man",
                                     20, 2)
            };
            _rewardPoints = 0;
        }
        public int RewardPoints
        {
            get => _rewardPoints;
            set
            {
                if (_rewardPoints != value)
                {
                    _rewardPoints = value;
                    OnPropertyChanged(nameof(RewardPoints));
                }
            }
        }

        public ObservableCollection<RewardViewModel> Rewards
        {
            get => _rewards;
            set
            {
                if (_rewards != value)
                {
                    _rewards = value;
                    OnPropertyChanged(nameof(Rewards));
                }
            }
        }

        public void PurchaseReward(RewardViewModel? rewardViewModel)
        {
        }

        public void ViewDetail(RewardViewModel? rewardViewModel)
        {
            throw new NotImplementedException();
        }
    }
}