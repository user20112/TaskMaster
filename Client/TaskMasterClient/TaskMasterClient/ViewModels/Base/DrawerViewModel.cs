using System.Collections.ObjectModel;

namespace TaskMasterClient.ViewModels.Base
{
    public class DrawerViewModel
    {
        public ObservableCollection<DrawerItemViewModel> Menus { get; set; } = new ObservableCollection<DrawerItemViewModel>();
        public Color SeparatorColor = new Color(.9f, .9f, .9f, 1);
        public DrawerViewModel()
        {
            SetupDrawerMenuLoggedOut();
        }
        void SetupDrawerMenuLoggedOut()
        {
            Menus.Add(new DrawerItemViewModel()
            {
                Image = "",
                OnTapped = new Command(() =>
                {

                }),
                Text = "Rewards"
            });
            Menus.Add(new DrawerItemViewModel()
            {
                Image = "",
                OnTapped = new Command(() =>
                {

                }),
                Text = "Punishments"
            });
            Menus.Add(new DrawerItemViewModel()
            {
                Image = "",
                OnTapped = new Command(() =>
                {

                }),
                Text = "Habits"
            });
            Menus.Add(new DrawerItemViewModel()
            {
                Image = "",
                OnTapped = new Command(() =>
                {

                }),
                Text = "Notes"
            });
        }
        void SetupDrawerMenuLoggedIn()
        {
            Menus.Add(new DrawerItemViewModel()
            {

            });
        }
    }
}
