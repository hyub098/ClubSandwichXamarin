using System;
using System.Collections.Generic;
using System.Linq;
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

        public void ConvertWeekId(List<Week> weeks)
        {
            var currentWeek = weeks[weeks.Count - 1];
            var currentWeekdId = currentWeek.WeekId;

            weeks = weeks.Select(x =>
            {
                x.PastWeek = currentWeekdId - x.WeekId;
                return x;
            }).ToList();
        }
    }

    public class WeekQueryResult
    {
        public List<Week> Weeks { get; set; }
    }
}
