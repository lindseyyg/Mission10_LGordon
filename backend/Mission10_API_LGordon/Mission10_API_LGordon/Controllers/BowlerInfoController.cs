using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_API_LGordon.Data;
using System.Collections.Generic;
using System.Linq;

namespace Mission10_API_LGordon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerInfoController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerInfoController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        //public IEnumerable<BowlerInfo> Get()
        public IEnumerable<object> Get()
        {
            var bowlerData = _bowlerRepository.GetBowlersWithTeamName();


            //return (bowlerData);

            //var bowlerData = _bowlerRepository.Bowlers
            //    //.Where(x => x.TeamInfo.TeamName == "Marlins" || x.TeamInfo.TeamName == "Sharks")
            //    .ToArray();


            return bowlerData;
        }
    }
}