using System.Threading.Tasks;
using TravelService.Db.Mongo.Schema;

namespace TravelService.Db.Mongo
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> FindByToken(string token);
        Task<Account> FindByGoogleId(string sub);
    }
}
