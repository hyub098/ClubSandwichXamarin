using System;
using System.Collections.Generic;
using System.ComponentModel;
using ClubSandwich.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace ClubSandwich
{
    public partial class MembersPage : ContentPage
    {

        private MembersViewModel membersViewModel;
        public MembersPage()
        {
            InitializeComponent();

            membersViewModel  = new MembersViewModel();
            this.BindingContext = membersViewModel;
        }

        protected override async void OnAppearing()
        {
            listView.BeginRefresh();
            await membersViewModel.UpdateMembers();
            listView.EndRefresh();

            base.OnAppearing();

        }
    }
}
