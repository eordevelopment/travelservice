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
            yield return GetTrip();
        }

        [HttpGet("{id}")]
        public TripDto Get(string id)
        {
            return GetTrip();
        }

        private static TripDto GetTrip()
        {
            return new TripDto
            {
                Id = "599a98f185142b3ce0f965a0",
                Name = "South Africa 2017",
                Key = "599a98f185142b3ce0f9659e",
                From = new DateTimeOffset(2017, 9, 29, 0, 0, 0, TimeSpan.FromHours(0)),
                To = new DateTimeOffset(2017, 10, 14, 0, 0, 0, TimeSpan.FromHours(0)),
                Flights = new List<Flight>
                {
                    new Flight
                    {
                        Name = "Dublin to Istanbul",
                        DepartureTime = new DateTimeOffset(2017, 9, 29, 16, 30, 0, TimeSpan.FromHours(1)),
                        ArrivalTime = new DateTimeOffset(2017, 9, 29, 22, 55, 0, TimeSpan.FromHours(3)),
                        DestinationAirport = "IST",
                        OriginAirport = "DUB",
                        FlightNumber = "TK1978"
                    },
                    new Flight
                    {
                        Name = "Istanbul to Durban",
                        DepartureTime = new DateTimeOffset(2017, 9, 30, 1, 35, 0, TimeSpan.FromHours(3)),
                        ArrivalTime = new DateTimeOffset(2017, 9, 30, 12, 50, 0, TimeSpan.FromHours(2)),
                        DestinationAirport = "DUR",
                        OriginAirport = "IST",
                        FlightNumber = "EK406",
                        Note = "via Jo'burg"
                    },
                    new Flight
                    {
                        Name = "Durban to Jo'burg",
                        DepartureTime = new DateTimeOffset(2017, 10, 13, 12, 10, 0, TimeSpan.FromHours(2)),
                        ArrivalTime = new DateTimeOffset(2017, 10, 13, 13, 15, 0, TimeSpan.FromHours(2)),
                        OriginAirport = "DUR",
                        DestinationAirport = "JNB", 
                        FlightNumber = "BA6226"
                    },
                    new Flight
                    {
                        Name = "Jo'burg to Istanbul",
                        DepartureTime = new DateTimeOffset(2017, 10, 13, 18, 20, 0, TimeSpan.FromHours(2)),
                        ArrivalTime = new DateTimeOffset(2017, 10, 14, 5, 0, 0, TimeSpan.FromHours(3)),
                        OriginAirport = "JNB",
                        DestinationAirport = "IST",
                        FlightNumber = "TK039"
                    },
                    new Flight
                    {
                        Name = "Istanbul to Dublin",
                        DepartureTime = new DateTimeOffset(2017, 10, 14, 7, 20, 0, TimeSpan.FromHours(3)),
                        ArrivalTime = new DateTimeOffset(2017, 10, 14, 9, 50, 0, TimeSpan.FromHours(1)),
                        OriginAirport = "IST",
                        DestinationAirport = "DUB",
                        FlightNumber = "TK1975"
                    }
                },
                CarRentals = new List<CarRental>
                {
                    new CarRental
                    {
                        Note = "Compact 4-door manual with A/C",
                        PickupTime = new DateTimeOffset(2017, 9, 30, 13, 0, 0, TimeSpan.FromHours(2)),
                        DropOffTime = new DateTimeOffset(2017, 10, 13, 8, 3, 0, TimeSpan.FromHours(2)),
                        Location = new Coord
                        {
                            Lat = -29.6147542,
                            Lon = 31.1058302
                        }
                    }
                },
                Hotels = new List<Hotel>
                {
                    new Hotel
                    {
                        Name = "Garden Court South Beach",
                        Address = "73 OR Tambo Parade, Durban 4056, South Africa",
                        Location = new Coord
                        {
                            Lat = -29.857411,
                            Lon = 31.0368003
                        },
                        NumNights = 1,
                        Note = "Bed and Breakfast",
                        CheckinTime = new DateTimeOffset(2017, 9, 30, 15, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g312595-d299215-Reviews-Garden_Court_South_Beach-Durban_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "St. Lucia Wetlands Guest House",
                        Address = "20 Kingfisher Street | Kwazulu-Natal, St Lucia 3936, South Africa",
                        Location = new Coord
                        {
                            Lat = -28.3751701,
                            Lon = 32.4153571
                        },
                        NumNights = 2,
                        Note = "Bed and Breakfast",
                        CheckinTime = new DateTimeOffset(2017, 10, 1, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g312636-d1411196-Reviews-St_Lucia_Wetlands_Guesthouse-St_Lucia_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "Thanda Tented Camp",
                        Address = "Off D242 between Hluhluwe & Mkhuze Kwazulu Natal 0114695082",
                        Location = new Coord
                        {
                            Lat = -27.8527124,
                            Lon = 32.1149074
                        },
                        NumNights = 2,
                        Note = "Full Board & Game Drives",
                        CheckinTime = new DateTimeOffset(2017, 10, 3, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g312602-d5486428-Reviews-Thanda_Tented_Camp-Mkuze_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "Cavern Drakensberg Resort & Spa",
                        Address = "End Of D 119 Road 3350 | Amphitheatre, Northern Drakensberg, Bergville 3350",
                        Location = new Coord
                        {
                            Lat = -28.636052,
                            Lon = 28.9588443
                        },
                        NumNights = 2,
                        Note = "Full Board & 1 Morning walk included",
                        CheckinTime = new DateTimeOffset(2017, 10, 5, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g488121-d480992-Reviews-Cavern_Drakensberg_Resort_Spa-Bergville_Drakensberg_Region_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "Drakensburg Sun Resort",
                        Address = "R600, Winterton 3340",
                        Location = new Coord
                        {
                            Lat = -29.007343,
                            Lon = 29.4211843
                        },
                        NumNights = 2,
                        Note = "Half Board",
                        CheckinTime = new DateTimeOffset(2017, 10, 7, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g662254-d485341-Reviews-Drakensberg_Sun_Resort-Winterton_Drakensberg_Region_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "Granny Mouse Country House",
                        Address = "Old Main Rd | R103, Balgowan 3275",
                        Location = new Coord
                        {
                            Lat = -29.4229146,
                            Lon = 30.0947127
                        },
                        NumNights = 2,
                        Note = "Bed and Breakfast",
                        CheckinTime = new DateTimeOffset(2017, 10, 9, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g1370253-d1368115-Reviews-Granny_Mouse_Country_House-Balgowan_KwaZulu_Natal.html"
                            }
                        }
                    },
                    new Hotel
                    {
                        Name = "Canelands Beach Club and Spa",
                        Address = "2 Shrimp Lane, Salt Rock 4391",
                        Location = new Coord
                        {
                            Lat = -29.50255,
                            Lon = 31.2367913
                        },
                        NumNights = 2,
                        Note = "Bed and Breakfast",
                        CheckinTime = new DateTimeOffset(2017, 10, 11, 14, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Name = "TripAdvisor",
                                Url = "https://www.tripadvisor.ie/Hotel_Review-g670772-d1820373-Reviews-Canelands_Beach_Club_and_Spa-Salt_Rock_KwaZulu_Natal.html"
                            }
                        }
                    }
                },
                Activities = new List<Activity>
                {
                    new Activity
                    {
                        Description = "Located at the southern end of World Heritage-listed iSimangaliso Wetland Park, St Lucia provides a great base for a range of activities including turtle tours, hippo boat cruises and snorkelling at Cape Vidal.",
                        StartTime = new DateTimeOffset(2017, 10, 1, 0, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link{Url = "http://www.extremenaturetours.co.za/Swim_with_Dolphins/swim_with_dolphins.htm"},
                            new Link{Url = "http://www.extremenaturetours.co.za/Cape_Vidal/cape_vidal_snorkeling.htm"}
                        }
                    },
                    new Activity
                    {
                        Name = "Whale watching",
                        Description = "Ocean Experience Whale Watching  57 Mckenzie Street | Main Road, St Lucia 3936, South Africa",
                        StartTime = new DateTimeOffset(2017, 10, 1, 0, 0, 0, TimeSpan.FromHours(2))
                    },
                    new Activity
                    {
                        Description = "Journey into the heart of KwaZulu-Natal’s big game country for a stay at the stylish Thanda Tented Camp. Enjoy game drives in search of elusive cheetah, hyena and of course the Big 5.",
                        StartTime = new DateTimeOffset(2017, 10, 3, 0, 0, 0, TimeSpan.FromHours(2))
                    },
                    new Activity
                    {
                        Description = "Explore river valleys on horseback, test your skills on a mountain bike trail or try your hand at fly fishing or golf. Don’t miss a trek in the uKhahlamba Drakensberg Park to marvel at the incredible Drakensberg Amphitheatre, a sheer 500m high rock wall which stretches over 5km, complete with one of the highest waterfalls in the world.",
                        StartTime = new DateTimeOffset(2017, 10, 5, 0, 0, 0, TimeSpan.FromHours(2))
                    },
                    new Activity
                    {
                        Description = "This picturesque corner of South Africa is renowned for its wide range of outdoor activities, suitable for all the family. Explore the area by mountain bike or on horseback, try your hand at trout fishing, enjoy a picnic with a view or zip along on a canopy tour through lush indigenous forest.",
                        StartTime = new DateTimeOffset(2017, 10, 7, 0, 0, 0, TimeSpan.FromHours(2))
                    },
                    new Activity
                    {
                        Description = "Spend the next couple of days exploring the surrounding area near Howick, affectionately known as the Midlands Meander. Indulge in some cake in one of the charming tea rooms, sample local produce including homemade cheeses and beers and browse for souvenirs in one of the many craft shops or art galleries.",
                        StartTime = new DateTimeOffset(2017, 10, 9, 0, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link{Url = "http://www.urbansprout.co.za/karkloof_market"},
                            new Link{Url = "https://www.tripadvisor.ie/Attraction_Review-g1057717-d4751632-Reviews-Benvie_Garden-Howick_KwaZulu_Natal.html"},
                            new Link{Url = "https://www.karkloofcanopytour.co.za/"}
                        }
                    },
                    new Activity
                    {
                        Description = "It’s time for a well-earned rest on the golden sands of the Dolphin Coast. Relax by the pool, take a stroll along the promenade or visit popular Willards Beach. ",
                        StartTime = new DateTimeOffset(2017, 10, 11, 0, 0, 0, TimeSpan.FromHours(2)),
                        Links = new List<Link>
                        {
                            new Link{Url = "http://www.hollatrails.co.za/index.html#top-home", Name = "Holla Trails - Mountain biking - Novice to Experienced"},
                            new Link{Url = "http://www.tidaltao.com/", Name = "Snorkelling - Ballito"},
                            new Link{Url = "https://www.sa-venues.com/things-to-do/kwazulunatal/ballito-boardwalk/", Name = "Ballito Boardwalk"}
                        }
                    }
                }
            };
        }
    }
}
