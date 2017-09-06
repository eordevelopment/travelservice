using System.Threading.Tasks;
using MongoDB.Driver;
using TravelService.Db.Mongo.Schema;

namespace TravelService.Db.Mongo.Repository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(IDbContext context) : base(context, "accounts")
        {
        }

        public Task<Account> FindByToken(string token)
        {
            return this.Collection.Find(x => x.UserToken == token).FirstOrDefaultAsync();
        }

        public Task<Account> FindByGoogleId(string sub)
        {
            return this.Collection.Find(x => x.Sub == sub).FirstOrDefaultAsync();
        }
    }
}
