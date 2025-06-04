using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages.Base
{
    public class BasePopup : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is BaseViewModel model)
            {
                model.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (BindingContext is BaseViewModel model)
            {
                model.OnDisappearing();
            }
        }
    }
}
