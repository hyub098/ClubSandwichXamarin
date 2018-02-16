using System;
using System.Collections.Generic;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

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
