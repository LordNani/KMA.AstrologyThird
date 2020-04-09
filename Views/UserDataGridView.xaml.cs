using CSharp_lab2.Navigation;
using CSharp_lab2.ViewModels;
using System.Windows.Controls;


namespace CSharp_lab2.Views
{
    /// <summary>
    /// Interaction logic for UserDataGridView.xaml
    /// </summary>
    public partial class UserDataGridView : UserControl, INavigatable
    {
        public UserDataGridView()
        {
            DataContext = new UserDataGridViewModel();
            InitializeComponent();
            
        }
    }
}
