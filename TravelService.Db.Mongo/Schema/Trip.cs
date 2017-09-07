using System;
using System.Collections.Generic;
using MongoDB.Bson;
using TravelService.Contract;

namespace TravelService.Db.Mongo.Schema
{
    public class Trip : IDocument
    {
        public ObjectId Id { get; set; }
        public string UserToken { get; set; }

        public string Name { get; set; }
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }
        public string Key { get; set; }

        public List<Flight> Flights { get; set; }
        public List<CarRental> CarRentals { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
