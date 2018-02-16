using System;
using Realms;

namespace ClubSandwich.Model
{
    public class User : RealmObject
    {
        [PrimaryKey]
        public long UserId { get; set; }
        public long FacebookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TotalOwed { get; set; }
        public string AvatarUrl { get; set; }
        public string FullName { get; set; }
    }
}
