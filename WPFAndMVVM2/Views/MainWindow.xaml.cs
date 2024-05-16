using System.Windows;
using WPFAndMVVM2.ViewModels;

namespace WPFAndMVVM2
{
 
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;
        }
    }
}
