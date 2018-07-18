using System.Windows;
using TicTacToe.Utilities.ApplicationServices;
using TicTacToe.ViewModel;

namespace TicTacToe.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel(ApplicationService.Instance.EventAggregator);
            InitializeComponent();
        }
    }
}