using System;
using Xamarin.Forms;

namespace ClubSandwich
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Page homePage, shoppingPage = null;

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

                
                    homePage.Icon = "home.png";
                    shoppingPage.Icon = "shopping_cart.png";
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

                    break;
            }

            Children.Add(homePage);
            Children.Add(shoppingPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }

    }
}
