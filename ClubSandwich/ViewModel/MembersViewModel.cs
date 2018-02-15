using System;
using System.Collections.Generic;
using ClubSandwich.Model;

namespace ClubSandwich.ViewModel
{
    public class MembersViewModel: BaseViewModel
    {
        public IList<User> Members { get; private set; }
            
        public MembersViewModel()
        {
            Title = "Members";
            Members = GetMembers();
        }

        public IList<User> GetMembers()
        {
            var user = new User
            {
                FacebookId = 1231,
                FirstName = "Oreo",
                LastName = "No",
                TotalOwed = 231,
                UserId = 123124
            };
            var memberList = new List<User>();
            for (var i = 0; i < 10; i++) {
                memberList.Add(user);
            }
            return memberList;
        }
    }
}
