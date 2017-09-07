using System;
using TravelService.Db.Mongo;
using Xunit.Abstractions;

namespace TravelService.Tests.Database
{
    public class BaseDatabaseTests : IDisposable
    {
        protected const string UserToken = "UserToken";

        protected string CollectionName;

        protected readonly IDbContext DbContext;
        protected readonly ITestOutputHelper Output;

        public BaseDatabaseTests(ITestOutputHelper output)
        {
            this.DbContext = new DbContext("mongodb://localhost:27017", "kitchenServiceV2Tests");
            this.Output = output;
        }

        public void Dispose()
        {
            this.DbContext.Db.DropCollection(this.CollectionName);
        }
    }
}
