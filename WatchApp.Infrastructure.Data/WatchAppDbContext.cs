using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Infrastructure.Data
{
    public class WatchAppDbContext: DbContext
    {
        public DbSet<Watches> Watches { get; set; }

        public WatchAppDbContext(DbContextOptions<WatchAppDbContext> opt): base(opt)
        { }
    }
}
