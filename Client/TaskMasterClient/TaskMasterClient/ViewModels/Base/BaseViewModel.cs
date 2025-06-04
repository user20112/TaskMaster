using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskMasterClient.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }


    public virtual async Task InitializeAsync(object? parameter)
    {
    }

    internal virtual void OnAppearing()
    {
    }

    internal virtual void OnDisappearing()
    {
    }
}