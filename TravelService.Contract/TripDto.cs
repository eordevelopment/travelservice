using System;
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
    }
}
