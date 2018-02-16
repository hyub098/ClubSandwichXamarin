using System;
using System.Collections.Generic;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class ShoppingPage : ContentPage
    {
        ShoppingViewModel shoppingViewModel;

        public ShoppingPage()
        {
            InitializeComponent();

            shoppingViewModel = new ShoppingViewModel();
            BindingContext = shoppingViewModel;
        }
    }
}
