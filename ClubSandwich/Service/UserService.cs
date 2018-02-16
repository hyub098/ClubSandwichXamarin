using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Services;

namespace ClubSandwich.Service
{
    public class UserService
    {
        private readonly GraphRequestService _requestService;

        public UserService()
        {
            _requestService = new GraphRequestService();
        }

        public async Task<GraphResult<MeQueryResult>> GetMyUserInfo()
        {
            string MeQueryString =
                @"query {
                    me {
                        userId
                        facebookId
                        firstName
                        lastName
                        avatarUrl
                        totalOwed
                    }
                }";

            return await _requestService.Query<MeQueryResult>(MeQueryString).ConfigureAwait(false);
        }

        public async Task<GraphResult<UsersQueryResult>> GetUsersInfo() {
            var usersQueryString = 
                @"query {
                    users {
                        userId
                        facebookId
                        firstName
                        lastName
                        avatarUrl
                        totalOwed
                      }
                    }";

            return await _requestService.Query<UsersQueryResult>(usersQueryString).ConfigureAwait(false);
        }
    }

    public class MeQueryResult
    {
        public User Me { get; set; }
    }

    public class UsersQueryResult
    {
        public IList<User> Users { get; set; }
    }
}
