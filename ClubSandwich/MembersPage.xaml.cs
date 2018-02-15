using System;
using System.Collections.Generic;
using ClubSandwich.ViewModel;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class MembersPage : ContentPage
    {

        public MembersPage()
        {

            InitializeComponent();

            this.BindingContext = new MembersViewModel();
            //listView.ItemsSource = membersViewModel.me;
        }
    }
}
