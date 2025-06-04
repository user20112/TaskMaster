using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Interfaces;

public interface INavigationService
{
    Task InitializeAsync();
    Task NavigateToAsync(Type viewModel);
    Task NavigateToAsync<TPage>() where TPage : BasePage;
    Page Init<TPage>() where TPage : FlyoutPage;
    Task NavigateToAsync<TPage>(object parameter) where TPage : BasePage;
    Task NavigateBackAsync();
    Task PopToRoot(bool animated = true);
    Task ChangeDrawerState(bool isPresented);
    Task PopPopup(object? result = null);
    Task ShowPopup<TPopup>(object parameter = null) where TPopup : BasePopup;
    Task<object?> ShowPopupForResult<TPopup>(object? parameter = null) where TPopup : BasePopup;
    Task ShowPopup<TPopup>(TPopup viewModel, object parameter = null) where TPopup : BasePopup;
    Task SetSlideOutDrawerEnabled(bool enabled);
    int CurrentDepth { get; }
}
