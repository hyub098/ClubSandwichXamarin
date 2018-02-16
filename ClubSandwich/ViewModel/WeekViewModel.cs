using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Services;
using Xamarin.Forms;

namespace ClubSandwich.ViewModel
{
    public class WeekViewModel
    {
        public IList<Week> Weeks;
        public WeekViewModel()
        {
            var requestService = new GraphRequestService();
            var queryString = "query {\r\n      me {\r\n        userId\r\n        totalCost\r\n        totalPaid\r\n      }\r\n      primaryShopper {\r\n        userId\r\n        firstName\r\n        bankDetails\r\n        bankName\r\n      }\r\n      weeks {\r\n        weekId\r\n        cost\r\n        costPerUser\r\n        users {\r\n          weekId\r\n          userId\r\n          slices\r\n          paid\r\n          user {\r\n            userId\r\n            firstName\r\n            lastName\r\n            avatarUrl\r\n          }\r\n        }\r\n        shopper {\r\n          userId\r\n          firstName\r\n          lastName\r\n          avatarUrl\r\n        }\r\n      }\r\n    }";
            var result = requestService.Query<Week>(queryString);
        }

        public IList<Week> GetWeeks()
        {
            return Weeks;
        }
        
    }
}
