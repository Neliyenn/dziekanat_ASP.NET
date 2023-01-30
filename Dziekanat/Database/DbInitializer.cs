using System;
using System.Linq;
using Dziekanat.Models;


namespace Dziekanat.Data
{
    public class DbInitializer
    {
        public static void Initialize(DziekanatContext context)
        {
            context.Database.EnsureCreated();
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            var user = new User[]{
                new User("admin","admin","admin","admin","employee"),
                new User("student","student","student","student","student"),
            };
            context.AddRange(user);

            context.SaveChanges();

        }
    }
}
