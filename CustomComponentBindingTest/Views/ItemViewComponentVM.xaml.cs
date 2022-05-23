using System;
using System.Collections.Generic;
using System.Diagnostics;
using CustomComponentBindingTest.ViewModels;
using Xamarin.Forms;

namespace CustomComponentBindingTest.Views {
    public partial class ItemViewComponentVM : ContentView {
        private TestViewModel viewModel;
        public ItemViewComponentVM() {
            BindingContext = viewModel = new TestViewModel();
            InitializeComponent();
        }


        public static readonly BindableProperty TestProperty = BindableProperty.Create(nameof(Test), typeof(string),
                                                                                        typeof(ItemViewComponentVM), propertyChanged: (bindable, oldVal, newVal) => {
                                                                                            Debug.WriteLine("TEST " + newVal);
                                                                                        });

        public string Test {
            get => (string)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }
    }
}
