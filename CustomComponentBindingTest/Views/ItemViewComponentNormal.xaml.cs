using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace CustomComponentBindingTest.Views {
    public partial class ItemViewComponentNormal : ContentView {
        public ItemViewComponentNormal() {
            InitializeComponent();
        }

        public static readonly BindableProperty TestProperty = BindableProperty.Create(nameof(Test), typeof(string),
                                                                                        typeof(ItemViewComponentNormal), propertyChanged: (bindable, oldVal, newVal) => {
                                                                                            Debug.WriteLine("TEST " + newVal);
                                                                                        });

        public string Test {
            get => (string)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }
    }
}
