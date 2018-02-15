using System;
using Xamarin.Forms;

namespace ClubSandwich
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Page homePage, shoppingPage, membersPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    homePage = new NavigationPage(new HomePage())
                    {
                        Title = "Home"
                    };

                    shoppingPage = new NavigationPage(new ShoppingPage())
                    {
                        Title = "Shopping"
                    };

                    membersPage = new NavigationPage(new MembersPage())
                    {
                        Title = "Members"
                    };

                    homePage.Icon = "home.png";
                    shoppingPage.Icon = "shopping_cart.png";
                    membersPage.Icon = "members.png";
                    break;
                default:
                    homePage = new HomePage()
                    {
                        Title = "Home"
                    };

                    shoppingPage = new ShoppingPage()
                    {
                        Title = "Shopping"
                    };

                    membersPage = new MembersPage()
                    {
                        Title = "Members"
                    };

                    break;
            }

            Children.Add(homePage);
            Children.Add(shoppingPage);
            Children.Add(membersPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }

    }
}