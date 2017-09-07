using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class Link
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Url { get; set; }
    }
}
