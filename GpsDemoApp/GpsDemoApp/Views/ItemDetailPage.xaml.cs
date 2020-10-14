using System.ComponentModel;
using Xamarin.Forms;
using GpsDemoApp.ViewModels;

namespace GpsDemoApp.Views
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