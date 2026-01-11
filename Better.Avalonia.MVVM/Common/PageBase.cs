using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Better.Avalonia.MVVM.Common;

public abstract partial class PageBase(string displayName) : ObservableValidator
{
    [ObservableProperty] private string _displayName = displayName;
    
    public virtual Task OnPageLoadedAsync() => Task.CompletedTask;
}