using System;
using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string FlightNumber { get; set; }
        [DataMember]
        public string OriginAirport { get; set; }
        [DataMember]
        public string DestinationAirport { get; set; }

        [DataMember]
        public DateTimeOffset DepartureTime { get; set; }
        [DataMember]
        public DateTimeOffset ArrivalTime { get; set; }

        [DataMember]
        public string Note { get; set; }
    }
}
