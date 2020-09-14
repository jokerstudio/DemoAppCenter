using System.ComponentModel;
using Xamarin.Forms;
using DemoAppCenter.ViewModels;

namespace DemoAppCenter.Views
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