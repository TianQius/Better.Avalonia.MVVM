using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Better.Avalonia.MVVM.Common;
using Better.Avalonia.MVVM.ViewModels;
using Better.Avalonia.MVVM.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Better.Avalonia.MVVM;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var services = new ServiceCollection();
            services.AddSingleton(desktop);
            var views = ConfigureViews(services);
            var provider = ConfigureServices(services);
            DataTemplates.Add(new ViewLocator(views));
            desktop.MainWindow = views.CreateView<MainWindowViewModel>(provider) as Window;
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
        {
            var services = new ServiceCollection();
            services.AddSingleton(singleView);
            var views = ConfigureViews(services);
            var provider = ConfigureServices(services);
            DataTemplates.Add(new ViewLocator(views));
            // Ideally, we want to create a MainView that host app content
            // and use it for both IClassicDesktopStyleApplicationLifetime and ISingleViewApplicationLifetime
            
        }

        base.OnFrameworkInitializationCompleted();
    }
    private static MainViews ConfigureViews(ServiceCollection services)
    {
        return new MainViews().AddView<MainWindow, MainWindowViewModel>(services);

    }
    private static ServiceProvider ConfigureServices(ServiceCollection services)
    {
        //services.AddSingleton<IManager, Manager>();
        return services.BuildServiceProvider();
    }
}