using DolzhenkovPR15.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DolzhenkovPR15.Views
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