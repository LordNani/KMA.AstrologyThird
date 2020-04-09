using System.Windows.Controls;
using CSharp_lab2.Navigation;
using CSharp_lab2.ViewModels;


namespace CSharp_lab2.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AddUserView : UserControl, INavigatable
    {
        public AddUserView()
        {
            InitializeComponent();
            DataContext = new AddUserViewModel();
        }
    }
}
