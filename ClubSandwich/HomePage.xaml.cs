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
        private MembersViewModel membersViewModel;
        public HomePage()
        {
            InitializeComponent();
            membersViewModel = new MembersViewModel();
            this.BindingContext = membersViewModel;
        }
    }
}
