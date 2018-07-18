using System.Windows;

namespace TicTacToe.View.config
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occured: " + e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            //Tells WPF we're done with the exception and nothing else should be done with it
            e.Handled = true;
        }
    }
}
