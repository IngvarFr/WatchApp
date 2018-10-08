using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Infrastructure.Data
{
    public class DBInitializier
    {
        public static void SeedDB(WatchAppDbContext ctx)
        {
            ctx.Database.EnsureCreated();
            /*var watch1 = ctx.Watches.Add(new Watches()
            {
                ProductName = "Rolex",
                ProductDescription ="Expensive as shizzle",
                Stock = 2,
                Price = 500,
                ProductPicture = "wow.jpeg"
            }).Entity;*/
            ctx.SaveChanges();
        }
    }
}
