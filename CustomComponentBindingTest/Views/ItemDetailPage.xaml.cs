using System.ComponentModel;
using Xamarin.Forms;
using CustomComponentBindingTest.ViewModels;

namespace CustomComponentBindingTest.Views {
    public partial class ItemDetailPage : ContentPage {
        public ItemDetailPage() {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
