using System;
using System.Collections.Generic;
using ClubSandwich.Model;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel HomeViewModel;
        public HomePage()
        {
            InitializeComponent();
            HomeViewModel = new HomeViewModel();
            this.BindingContext = HomeViewModel;
        }

        protected override async void OnAppearing()
        {
            WeekView.BeginRefresh();
            await HomeViewModel.UpdateWeeks();
            WeekView.EndRefresh();
            base.OnAppearing();
        }
    }
}
