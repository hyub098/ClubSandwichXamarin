using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Service;

namespace ClubSandwich.ViewModel
{
    public class MembersViewModel: BaseViewModel
    {
        public IList<User> Members { get; set; }
            
        UserService _userService;

        public MembersViewModel()
        {
            Title = "Members";
        }

        public async Task UpdateMembers()
        {
            _userService = new UserService();
            var response = await _userService.GetUsersInfo().ConfigureAwait(false);

            Members = response.Data.Users.Select(x => {
                x.FullName = x.FirstName + " " + x.LastName;
                return x;
            }).ToList();
            OnPropertyChanged(nameof(Members));
        }
    }
}
