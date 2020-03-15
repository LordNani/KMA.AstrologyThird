using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
using CSharp_lab2.ViewModels;
namespace CSharp_lab2
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SignViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _viewModel = new SignViewModel();
            
        }
    }
}
