using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClubSandwich.Model;

namespace ClubSandwich.ViewModel
{
    public class HomeViewModel: BaseViewModel
    {
        public IList<Week> Weeks { get; set; }
        public HomeViewModel()
        {
            Title = "Home";
        }

        public async Task UpdateWeeks()
        {
            return;
        }
    }
}
