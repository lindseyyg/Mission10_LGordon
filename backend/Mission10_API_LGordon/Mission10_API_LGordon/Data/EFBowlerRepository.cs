
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mission10_API_LGordon.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp) { 
            _bowlerContext = temp;
        }
        public IEnumerable<BowlerInfo> Bowlers => _bowlerContext.Bowlers/*.Include(x => x.TeamInfo)*/;
        public IEnumerable<TeamInfo> Teams => _bowlerContext.Teams;

        public IEnumerable<object> GetBowlersWithTeamName()
        {
            var query = from b in Bowlers
                        join t in Teams on b.TeamID equals t.TeamID
                        where t.TeamName == "Marlins" || t.TeamName == "Sharks"
                        select new
                        {
                            BowlerID = b.BowlerID,
                            BowlerLastName = b.BowlerLastName,
                            BowlerFirstName = b.BowlerFirstName,
                            BowlerMiddleInit = b.BowlerMiddleInit,
                            BowlerAddress = b.BowlerAddress,
                            BowlerCity = b.BowlerCity,
                            BowlerState = b.BowlerState,
                            BowlerZip = b.BowlerZip,
                            BowlerPhoneNumber = b.BowlerPhoneNumber,
                            TeamName = t.TeamName
                        };
            return query.ToList();
        }
    }
}
