using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaOnTime.ViewModels;
using AvaloniaOnTime.Views;

namespace AvaloniaOnTime
{
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
                desktop.MainWindow = new TasksScreen
                {
                    //DataContext = new MainWindowViewModel(),
                    DataContext = new TasksScreenViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}