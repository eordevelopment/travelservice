using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TravelService.Contract;

namespace TravelService.Controllers
{
    [Route("api/[controller]")]
    public class TripController : Controller
    {
        // GET: api/status
        [HttpGet]
        public IEnumerable<TripDto> Get()
        {
            for (var i = 0; i < 5; i++)
            {
                yield return new TripDto
                {
                    Id = i.ToString(),
                    Name = "Trip " + i,
                    From = DateTimeOffset.Now.AddYears(-i),
                    To = DateTimeOffset.Now.AddYears(-i).AddDays(14)
                };
            }
        }
    }
}
