using System.ComponentModel;
using WishList.ViewModels;
using Xamarin.Forms;

namespace WishList.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}