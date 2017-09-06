using MongoDB.Bson;

namespace TravelService.Db.Mongo.Schema
{
    public class Account : IDocument
    {
        public ObjectId Id { get; set; }
        public string UserToken { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Sub { get; set; }
    }
}
