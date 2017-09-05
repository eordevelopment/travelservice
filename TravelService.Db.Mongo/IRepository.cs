using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using TravelService.Db.Mongo.Schema;

namespace TravelService.Db.Mongo
{
    public interface IRepository<TEntity> where TEntity : IDocument
    {
        string CollectionName { get; }

        Task<List<TEntity>> GetAll(string userToken);
        Task<TEntity> Get(ObjectId id);
        Task<List<TEntity>> Get(IReadOnlyCollection<ObjectId> ids);
        Task Upsert(TEntity e);
        Task Upsert(IReadOnlyCollection<TEntity> entities);
        Task Remove(TEntity entity);
        Task Remove(ObjectId id);
    }
}
