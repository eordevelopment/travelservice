using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelService.Contract;
using TravelService.Db.Mongo;
using TravelService.Db.Mongo.Schema;

namespace TravelService.Controllers
{
    [Route("api/[controller]")]
    public class AccountController
    {
        private readonly IAccountRepository _repository;

        public AccountController(IAccountRepository repository)
        {
            this._repository = repository;
        }

        [HttpPost("/api/account/login")]
        public async Task<string> Login([FromBody]LoginDto value)
        {
            if (string.IsNullOrWhiteSpace(value.IdToken))
            {
                throw new ArgumentException("token cannot be empty");
            }

            using (var client = new System.Net.Http.HttpClient())
            {
                var respose = await client.GetAsync(string.Format("https://www.googleapis.com/oauth2/v3/tokeninfo?id_token={0}", value.IdToken));

                Console.WriteLine(respose.StatusCode);
                if ((int)respose.StatusCode != 200)
                    throw new InvalidOperationException($"Code: {respose.StatusCode}");

                var serialized = respose.Content.ReadAsStringAsync().Result;
                Console.WriteLine(serialized);
                var user = JsonConvert.DeserializeObject<Account>(serialized);
                var existingAccount = await this._repository.FindByGoogleId(user.Sub);
                if (existingAccount != null) return existingAccount.UserToken;

                user.UserToken = Guid.NewGuid().ToString();
                await this._repository.Upsert(user);
                return user.UserToken;
            }
        }
    }
}
