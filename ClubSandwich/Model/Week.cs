using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubSandwich.Model
{
    public class Week
    {
        public int WeekId { get; set; }
        public float Cost { get; set; }
        public decimal CostPerUser { get; set; }
        public List<UserWeekLink> Users { get; set; }
        public User Shopper { get; set; }
        public int PastWeek { get; set; }
    }
}
