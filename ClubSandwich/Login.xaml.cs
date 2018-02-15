using System;
using System.Collections.Generic;
using ClubSandwich.Model;
using ClubSandwich.Service;
using Realms;
using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class Login : ContentPage
    {
        Effect fontEffect;
        Realm _realm;

        public Login()
        {
            _realm = RealmConnection.GetInstance();

            InitializeComponent();
            fontEffect = new LabelFontEffect();

            Title.Effects.Add(fontEffect);
        }

        void Login_Clicked(object sender, EventArgs e) {
            // TODO: use Token.Text to pass in bearer token to api before navigatin
            var transaction = _realm.BeginWrite();

            _realm.Add<LoginCredential>(new LoginCredential() { Token = Token.Text });

            transaction.Commit();
            transaction.Dispose();

            App.Current.MainPage = new MainPage();
        }
    }
}
