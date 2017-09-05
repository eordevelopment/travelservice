using MongoDB.Bson;

namespace TravelService.Db.Mongo.Schema
{
    public interface IDocument
    {
        ObjectId Id { get; set; }
        string UserToken { get; set; }
    }
}
