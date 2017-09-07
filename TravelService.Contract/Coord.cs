using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class Coord
    {
        [DataMember]
        public double Lat { get; set; }
        [DataMember]
        public double Lon { get; set; }
    }
}
