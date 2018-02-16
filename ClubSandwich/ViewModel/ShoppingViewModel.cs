using System;
using System.Collections.Generic;
using System.Linq;
using ClubSandwich.Model;
using ClubSandwich.Service;

namespace ClubSandwich.ViewModel
{
    public class ShoppingViewModel : BaseViewModel
    {
        WeekService _weekService;

        IList<Week> Weeks;
        
        public ShoppingViewModel()
        {
            Title = "Shopping";
        }

        public async void GetShoppingInfo()
        {
            _weekService = new WeekService();

            var response = await _weekService.GetWeeks().ConfigureAwait(false);
            Weeks = response.Data.Weeks.Select(x =>
            {
                x.Shopper.FullName = x.Shopper.FirstName + " " + x.Shopper.LastName;
                return x;
            }).ToList();

            OnPropertyChanged("Weeks");
        }
    }
}
