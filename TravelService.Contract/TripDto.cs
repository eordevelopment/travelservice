﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class TripDto
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTimeOffset From { get; set; }

        [DataMember]
        public DateTimeOffset To { get; set; }

        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public List<Flight> Flights { get; set; }
        [DataMember]
        public List<CarRental> CarRentals { get; set; }
        [DataMember]
        public List<Hotel> Hotels { get; set; }
        [DataMember]
        public List<Activity> Activities { get; set; }
    }
}
