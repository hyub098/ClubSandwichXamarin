using System;
using System.Collections.Generic;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class ShoppingPage : ContentPage
    {
        private ShoppingViewModel shoppingViewModel;

        public ShoppingPage()
        {
            InitializeComponent();

            shoppingViewModel = new ShoppingViewModel();
            BindingContext = shoppingViewModel;
        }

        protected override async void OnAppearing()
        {
            listView.BeginRefresh();
            await shoppingViewModel.GetShoppingInfo();
            listView.EndRefresh();

            base.OnAppearing();
        }
    }
}
