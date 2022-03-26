using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_Api.IServices;
using Travel_Api.Models;

namespace Travel_Api.Controllers
{
    public class TravelController : ControllerBase
    {
        private readonly ITravelServices travelService;
        public TravelController(ITravelServices travel)
        {
            travelService = travel;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Travellerdata")]
        public IEnumerable<Travel> GetTravel()
        {
            return travelService.GetTravel();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Travel/AddTravel")]
        public Travel AddPortfolio(Travel trvl)
        {
            return travelService.AddTravel(trvl);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Travel/EditTravel")]
        public Travel EditTravel(Travel trvl)
        {
            return travelService.EditTravel(trvl);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Travel/DeleteTravel")]
        public Travel DeleteTravel(int id)
        {
            return travelService.DeleteTravel(id);
        }
    }
}

