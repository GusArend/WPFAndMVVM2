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

        private void btnNewPerson_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AddDefaultPerson();
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DeleteSelectedPerson();
        }
    }
}
