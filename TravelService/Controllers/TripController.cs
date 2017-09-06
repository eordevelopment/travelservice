using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelService.Contract;

namespace TravelService.Controllers
{
    [Authorize(Policy = "HasToken")]
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

        [HttpGet("{id}")]
        public TripDto Get(string id)
        {
            return new TripDto
            {
                Id = id,
                Name = "Trip " + id,
                From = DateTimeOffset.Now,
                To = DateTimeOffset.Now.AddDays(14)
            };
        }
    }
}
