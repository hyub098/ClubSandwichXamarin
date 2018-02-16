using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Service;
using Xamarin.Forms;
using static Xamarin.Forms.Device;

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
            //_userService = new UserService();
            //var response = await _userService.GetUsersInfo().ConfigureAwait(false);

            //Members = response.Data.Users.Select(x =>
            //{
            //    x.FullName = x.FirstName + " " + x.LastName;
            //    return x;
            //}).ToList();
            Members = new List<User>();
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Mike",
                LastName = "Little",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.8.50.50/p50x50/20294234_10155706511688442_2085983101812998160_n.jpg?oh=f1b01cb2d62bf0a5cdf5dd654fb9c82e&oe=5B17BD88",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Dom",
                LastName = "Kim",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });
            Members.Add(new User()
            {
                FirstName = "Callum",
                LastName = "Fitt-Simpson",
                AvatarUrl = "https://scontent.xx.fbcdn.net/v/t1.0-1/c0.0.50.50/p50x50/10593235_866933526684437_3946471281426302274_n.jpg?oh=8a45b3c12109a2271ac2f76518597f92&oe=5B08D65A",
                TotalOwed = 4.233333587646467
            });

            Members = Members.Select(x =>
            {
                x.FullName = x.FirstName + " " + x.LastName;
                return x;
            }).ToList();

            OnPropertyChanged(nameof(Members));
        }
    }
}
