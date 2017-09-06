using System.Runtime.Serialization;

namespace TravelService.Contract
{
    [DataContract]
    public class LoginDto
    {
        [DataMember]
        public string IdToken { get; set; }
    }
}
