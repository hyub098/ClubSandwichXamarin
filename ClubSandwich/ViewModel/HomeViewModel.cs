using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Service;

namespace ClubSandwich.ViewModel
{
    public class HomeViewModel: BaseViewModel
    {
        public IList<Week> Weeks { get; set; }
        WeekService _weekSevice;

        public HomeViewModel()
        {
            Title = "Home";
        }

        public async Task UpdateWeeks()
        {
            _weekSevice = new WeekService();
            var response = await _weekSevice.GetWeeks().ConfigureAwait(false);

            Weeks = response.Data.Weeks;
            OnPropertyChanged(nameof(Weeks));
        }
    }
}
