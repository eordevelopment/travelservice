using System;
using System.Linq;
using System.Threading.Tasks;
using TravelService.Db.Mongo;
using TravelService.Db.Mongo.Repository;
using TravelService.Db.Mongo.Schema;
using Xunit;
using Xunit.Abstractions;

namespace TravelService.Tests.Database
{
    public class TripRepositoryTests : BaseDatabaseTests
    {
        private readonly ITripRepository _sut;

        public TripRepositoryTests(ITestOutputHelper output) : base(output)
        {
            this._sut = new TripRepository(this.DbContext);
            this.CollectionName = this._sut.CollectionName;
        }

        [Fact]
        public async Task ShouldPersistDateTimeOffset()
        {
            var trip = new Trip
            {
                UserToken = UserToken,
                From = DateTimeOffset.Now,
                Key = "key",
                Name = "Name",
                To = new DateTimeOffset(2017, 9, 29, 12, 0, 0, 0, TimeSpan.FromHours(2))
            };

            this.Output.WriteLine($"From Time: {trip.From}");
            this.Output.WriteLine($"To Time: {trip.To}");

            await this._sut.Upsert(trip);

            var trips = await this._sut.GetAll(UserToken);

            Assert.NotEmpty(trips);
            var dbTrip = trips.First();
            this.Output.WriteLine($"Db From Time: {dbTrip.From}");
            this.Output.WriteLine($"Db To Time: {dbTrip.To}");

            Assert.Equal(trip.From, dbTrip.From);
            Assert.Equal(trip.To, dbTrip.To);
        }
    }
}
