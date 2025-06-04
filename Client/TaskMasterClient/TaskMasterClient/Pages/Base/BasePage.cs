using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Pages.Base
{
    public class BasePage : ContentPage
    {
        public Command HelpCommand { get; set; }
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

        public virtual async Task InitializeAsync(object value)
        {
        }
    }
}
