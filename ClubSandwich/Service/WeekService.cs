using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClubSandwich.Model;
using ClubSandwich.Services;

namespace ClubSandwich.Service
{
    public class WeekService
    {
        private readonly GraphRequestService _requestService;

        public WeekService()
        {
            _requestService = new GraphRequestService();
        }

        public async Task<GraphResult<WeekQueryResult>> GetWeeks()
        {
            string GetWeeksQueryResult =
                @"query {
                    weeks {
                        cost
                        costPerUser
                        users {
                          paid
                          user {
                            firstName
                            lastName
                            avatarUrl
                          }
                        }
                        shopper {
                          firstName
                          lastName
                          avatarUrl
                        }
                    }
                }";

            return await _requestService.Query<WeekQueryResult>(GetWeeksQueryResult);
        }
    }

    public class WeekQueryResult
    {
        public List<Week> Week { get; set; }
    }
}
