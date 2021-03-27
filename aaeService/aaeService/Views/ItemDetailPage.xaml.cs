using aaeService.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace aaeService.Views
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