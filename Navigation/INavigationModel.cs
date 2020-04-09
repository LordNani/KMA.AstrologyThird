using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lab2.Navigation
{

    internal enum ViewType
    {
        AddUser,
        EditUser,
        UserDataGridView,
    }
    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
