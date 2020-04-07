using System.Windows;
using System.Windows.Controls;
using CSharp_lab2.ViewModels;
using CSharp_lab2.Tools;
namespace CSharp_lab2
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        private SignViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel = new SignViewModel();
            
        }

        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }

    }
}
