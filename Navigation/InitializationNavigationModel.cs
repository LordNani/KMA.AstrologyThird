using System;
using CSharp_lab2.Tools;
using CSharp_lab2.ViewModels;
using CSharp_lab2.Views;
using AddUserView = CSharp_lab2.Views.AddUserView;
using UserDataGridView = CSharp_lab2.Views.UserDataGridView;


namespace CSharp_lab2.Navigation
{
    class InitializationNavigationModel : BaseNavigationModel, INavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.AddUser:
                    ViewsDictionary.Add(viewType, new AddUserView());
                    break;
                case ViewType.EditUser:
                    ViewsDictionary.Add(viewType, new EditUserView());
                    break;
                case ViewType.UserDataGridView:
                    ViewsDictionary.Add(viewType, new UserDataGridView());
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(viewType),viewType,null);
            }     

           
        }
    }
}
