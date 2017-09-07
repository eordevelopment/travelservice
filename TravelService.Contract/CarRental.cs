using System;
using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class CarRental
    {
        [DataMember]
        public DateTimeOffset PickupTime { get; set; }
        [DataMember]
        public DateTimeOffset DropOffTime { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public Coord Location { get; set; }
    }
}
