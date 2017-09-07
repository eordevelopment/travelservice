using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int NumNights { get; set; }
        [DataMember]
        public DateTimeOffset CheckinTime { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public Coord Location { get; set; }

        public List<Link> Links { get; set; }
    }
}
