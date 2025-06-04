using CommunityToolkit.Maui.Views;
using TaskMasterClient.Interfaces;
using TaskMasterClient.Pages.Base;
using TaskMasterClient.ViewModels;

namespace TaskMasterClient.Services;

public class NavigationService : INavigationService
{
    private readonly SemaphoreSlim _navigationLock = new(1, 1);
    private FlyoutPage MainPage
    {
        get
        {
            return (FlyoutPage)Application.Current.MainPage;
        }
    }

    public INavigation Navigation
    {
        get
        {
            return MainPage.Detail.Navigation;
        }
    }

    public NavigationService()
    {
    }

    public int CurrentDepth
    {
        get
        {
            var navigationPage = Application.Current.MainPage as NavigationPage;
            if (navigationPage != null)
            {
                return navigationPage.Navigation.NavigationStack.Count();
            }
            else
            {
                var flyoutPage = Application.Current.MainPage as FlyoutPage;
                if (flyoutPage != null)
                {
                    navigationPage = flyoutPage.Detail as NavigationPage;
                    if (navigationPage != null)
                    {
                        return navigationPage.Navigation.NavigationStack.Count();
                    }
                }
            }
            return 0;
        }
    }

    public Task InitializeAsync()
    {
        return NavigateToAsync<BasePage>();
    }

    public Task NavigateToAsync(Type page)
    {
        return InternalNavigateToAsync(page, null);
    }

    public Task NavigateToAsync<TPage>() where TPage : BasePage
    {
        return InternalNavigateToAsync(typeof(TPage), null);
    }

    public Task NavigateToAsync<TPage>(object parameter) where TPage : BasePage
    {
        return InternalNavigateToAsync(typeof(TPage), parameter);
    }

    public async Task NavigateBackAsync()
    {
        var navigationPage = Application.Current.MainPage as NavigationPage;
        if (navigationPage != null)
        {
            await navigationPage.PopAsync().ConfigureAwait(false);
        }
        else
        {
            var flyoutPage = Application.Current.MainPage as FlyoutPage;
            if (flyoutPage != null)
            {
                navigationPage = flyoutPage.Detail as NavigationPage;
                if (navigationPage != null)
                {
                    await navigationPage.PopAsync().ConfigureAwait(false);
                }
            }
        }
    }

    private async Task InternalNavigateToAsync(Type pageType, object parameter)
    {
        if (!await _navigationLock.WaitAsync(0))
        {
            return;
        }
        try
        {
            Page page = CreatePage(pageType, parameter);

            if (page.BindingContext is BaseViewModel viewmodel)
            {
                await viewmodel.InitializeAsync(parameter);
            }

            switch (Application.Current.MainPage)
            {
                case NavigationPage navigationPage:
                    await navigationPage.PushAsync(page);
                    break;
                case FlyoutPage flyoutPage when flyoutPage.Detail is NavigationPage NavigationPage:
                    await NavigationPage.PushAsync(page);
                    break;
                default:
                    Application.Current.MainPage = new NavigationPage(page);
                    break;
            }
        }
        catch (Exception ex)
        {
        }
        finally
        {
            _navigationLock.Release();
        }
    }

    public Page Init<TPage>() where TPage : FlyoutPage
    {
        try
        {
            return CreatePage(typeof(TPage), null);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    private Page CreatePage(Type pageType, object parameter)
    {
        return Activator.CreateInstance(pageType) as Page;
    }

    public async Task ChangeDrawerState(bool isPresented)
    {
        var flyoutPage = Application.Current.MainPage as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.IsPresented = isPresented;
        }
    }

    private Popup? _currentPopup;

    public async Task PopPopup(object? result = null)
    {
        if (_currentPopup != null)
        {
            await _currentPopup.CloseAsync(result);
            _currentPopup = null;
        }
    }

    public Task ShowPopup<TPopup>(object? parameter = null) where TPopup : BasePopup
    {
        return InternalShowPopupAsync(typeof(TPopup), parameter);
    }

    public Task ShowPopup<TPopup>(TPopup popup, object? parameter = null) where TPopup : BasePopup
    {
        return InternalShowPopupAsync(typeof(TPopup), parameter);
    }

    public Task<object?> ShowPopupForResult<TPopup>(object? parameter = null) where TPopup : BasePopup
    {
        Popup popup = CreatePopup(typeof(TPopup), parameter);
        if (_currentPopup is not null)
        {
            PopPopup();
        }

        _currentPopup = popup;

        NavigationPage? navigationPage = Application.Current.MainPage switch
        {
            NavigationPage customNavigation => customNavigation,
            FlyoutPage flyoutPage => flyoutPage.Detail as NavigationPage,
            _ => null
        };

        if (navigationPage is not null)
        {
            (popup.BindingContext as BasePopupViewModel)?.InitializeAsync(parameter);
            return navigationPage.ShowPopupAsync(popup, CancellationToken.None);
        }

        return Task.FromResult<object?>(null);
    }

    private async Task InternalShowPopupAsync(Type popupType, object? parameter)
    {
        Popup popup = CreatePopup(popupType, parameter);
        if (_currentPopup != null)
        {
            await PopPopup();
        }
        _currentPopup = popup;
        var navigationPage = Application.Current.MainPage as NavigationPage;
        if (navigationPage != null)
        {
            navigationPage.ShowPopup(popup);
        }
        else
        {
            var flyoutPage = Application.Current.MainPage as FlyoutPage;
            if (flyoutPage != null)
            {
                navigationPage = flyoutPage.Detail as NavigationPage;
                if (navigationPage != null)
                {
                    navigationPage.ShowPopup(popup);
                }
            }
        }

        await (popup.BindingContext as BasePopupViewModel).InitializeAsync(parameter);
    }

    private Popup CreatePopup(Type popupType, object? parameter)
    {
        Popup popup = Activator.CreateInstance(popupType) as Popup;
        return popup;
    }


    public async Task SetSlideOutDrawerEnabled(bool enabled)
    {
        MainPage.IsGestureEnabled = enabled;
    }

    public async Task PopToRoot(bool animated = true)
    {
        await Navigation.PopToRootAsync(animated);
    }

}