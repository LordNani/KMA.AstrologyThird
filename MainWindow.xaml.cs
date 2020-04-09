using System.Windows;
using CSharp_lab2.ViewModels;
using CSharp_lab2.Views;


namespace CSharp_lab2
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
            
        }


    }
}
