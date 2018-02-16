using System;
using System.Collections.Generic;
using ClubSandwich.Model;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class HomePage : ContentPage
    {
        public IList<Week> Weeks;
        public HomePage()
        {
            InitializeComponent();
            Weeks = new WeekViewModel().GetWeeks();
            
            Users.ItemsSource = Weeks;
        }
    }
}
