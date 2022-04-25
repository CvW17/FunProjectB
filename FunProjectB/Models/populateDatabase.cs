namespace FunProjectB.Models
{
    public class populateDatabase
    {
        public static void Initialize(Data.Context context)
        {
            if (context.Continents.Any())
            {
                return;
            }

            var continents = new Continents[]
            {
                new Continents{Continent = "Africa"},
                new Continents{Continent = "Asia"},
                new Continents{Continent = "Europe"}
            };
            context.Continents.AddRange(continents);
            context.SaveChanges();

            var cities = new Cities[]
            {
                new Cities{City = "Cape Town"},
                new Cities{City = "Tokyo"},
                new Cities{City = "Munich"}
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();

            var countries = new Countries[]
            {
                new Countries{Country = "South Africa"},
                new Countries{Country = "Japan"},
                new Countries{Country = "Germany"}
            };

            context.Countries.AddRange(countries);
            context.SaveChanges();
        }
    }
}
