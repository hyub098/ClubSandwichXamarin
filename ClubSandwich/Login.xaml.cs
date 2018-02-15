using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClubSandwich
{
    public partial class Login : ContentPage
    {
        Effect fontEffect;

        public Login()
        {
            InitializeComponent();
            fontEffect = new LabelFontEffect();

            Title.Effects.Add(fontEffect);
        }

        void Login_Clicked(object sender, EventArgs e) {
            App.Current.MainPage = new MainPage();
        }
    }
}
