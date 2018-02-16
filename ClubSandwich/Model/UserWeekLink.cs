using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSandwich.Model
{
    public class UserWeekLink
    {
        public int UserId { get; set; }
        public int WeekId { get; set; }
        public float Paid { get; set; }
        public User User { get; set; }
        public Week Week { get; set; }
    }
}
