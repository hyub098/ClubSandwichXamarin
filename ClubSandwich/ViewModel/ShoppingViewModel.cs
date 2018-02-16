using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Service;

namespace ClubSandwich.ViewModel
{
    public class ShoppingViewModel : BaseViewModel
    {
        WeekService _weekService;

        public IList<Week> Weeks { get; set; }
        
        public ShoppingViewModel()
        {
            Title = "Shopping";
        }

        public async Task GetShoppingInfo()
        {
            _weekService = new WeekService();

            var response = await _weekService.GetWeeks().ConfigureAwait(false);
            Weeks = response.Data.Weeks.Select(x =>
            {
                x.Shopper.FullName = x.Shopper.FirstName + " " + x.Shopper.LastName;
                return x;
            }).OrderByDescending(x => x.WeekId).ToList();

            OnPropertyChanged("Weeks");
        }
    }
}
