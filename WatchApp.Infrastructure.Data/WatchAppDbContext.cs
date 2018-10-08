using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WatchApp.Infrastructure.Data
{
    public class WatchAppDbContext: DbContext
    {
        public DbSet<WatchesRepository> Watches { get; set; }

        public WatchAppDbContext(DbContextOptions<WatchAppDbContext> opt): base(opt)
        { }
    }
}
