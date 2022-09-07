using AutoRent.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Data
{
    public class Seeder
    {
        public static async Task SeedDb(AutoRentDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            await dbContext.Database.EnsureCreatedAsync();

            if (!dbContext.Users.Any())
            {

                var json = File.ReadAllText(Path.Combine(baseDir, "dbseed/users.json"));

                var users = JsonConvert.DeserializeObject<List<User>>(json);

                await dbContext.AddRangeAsync(users);
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Locations.Any())
            {

                var json = File.ReadAllText(Path.Combine(baseDir, "dbseed/locations.json"));

                var locations = JsonConvert.DeserializeObject<List<Location>>(json);

                await dbContext.AddRangeAsync(locations);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
