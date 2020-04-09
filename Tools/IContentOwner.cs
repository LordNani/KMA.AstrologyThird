using CSharp_lab2.Navigation;
using System.Windows.Controls;

namespace CSharp_lab2.Tools
{
    internal interface IContentOwner
    {
        INavigatable Content{ get; set; }
    }
}
