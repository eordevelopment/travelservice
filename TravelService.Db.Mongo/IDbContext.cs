using MongoDB.Driver;

namespace TravelService.Db.Mongo
{
    public interface IDbContext
    {
        IMongoDatabase Db { get; }
    }
}
