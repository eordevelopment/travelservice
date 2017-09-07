using TravelService.Db.Mongo.Schema;

namespace TravelService.Db.Mongo.Repository
{
    public class TripRepository : Repository<Trip>, ITripRepository
    {
        public TripRepository(IDbContext context) : base(context, "trips")
        {
        }
    }
}
