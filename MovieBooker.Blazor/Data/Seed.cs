using MovieBooker.DataAccess;
using MovieBooker.DataAccess.Model;

namespace MovieBooker.Blazor.Data
{
    public class Seed
    {
        public static async Task SeedData(MovieBookerDbContext context)
        {
            if (context.Address.Any() ||
                context.Bookings.Any() ||
                context.Categorys.Any() ||
                context.Cinemas.Any() ||
                context.Movies.Any() ||
                context.OpeningTimes.Any() ||
                context.Roles.Any() ||
                context.Rooms.Any() ||
                context.Runtimes.Any() ||
                context.Seats.Any() ||
                context.SpecialOpeningTimes.Any() ||
                context.Tags.Any() ||
                context.Users.Any()) return;


            //seed user
            //seed roles

            var AddressList = new List<Address>
            {
                new Address
                {
                    AddressLine = "Randomstreet 1",
                    City = "Aalborg",
                    Region = "Nordjylland",
                    PostalCode = "9000",
                    Country = "Denmark"
                },
                new Address
                {
                    AddressLine = "Randomstreet 2",
                    City = "Aarhus",
                    Region = "Midjylland",
                    PostalCode = "9000",
                    Country = "Denmark"
                },
                new Address
                {
                    AddressLine = "Randomstreet 3",
                    AddressLine2 = "A12",
                    City = "Kolling",
                    Region = "Sydjylland",
                    PostalCode = "9000",
                    Country = "Denmark"
                },
                new Address
                {
                    AddressLine = "Randomstreet 4",
                    AddressLine2 = "H14",
                    City = "København",
                    Region = "Sjælland",
                    PostalCode = "9000",
                    Country = "Denmark"
                },

            };

            //Categorys
            //tags
            //Cinimas
            //Movies
            //OpeningTimes
            //Special Openingtimes
            //Rooms

            //CategoryMovie
            //MovieTag

            //Runtimes
            //Seats
            //Bookings
            //
        }
    }
}
