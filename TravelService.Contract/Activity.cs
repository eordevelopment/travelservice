using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class Activity
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTimeOffset? StartTime { get; set; }
        [DataMember]
        public DateTimeOffset? EndTime { get; set; }
        [DataMember]
        public Coord Location { get; set; }
        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public List<Link> Links { get; set; }
    }
}
