using System;
using System.Collections.Generic;
using CustomComponentBindingTest.ViewModels;
using CustomComponentBindingTest.Views;
using Xamarin.Forms;

namespace CustomComponentBindingTest {
    public partial class AppShell : Xamarin.Forms.Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
