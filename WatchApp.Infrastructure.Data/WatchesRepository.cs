using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.DomainServices;
using WatchApp.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WatchApp.Infrastructure.Data
{
    public class WatchesRepository : IWatchesRepository
    {
        private WatchAppDbContext _ctx;

        public WatchesRepository(WatchAppDbContext ctx)
        {
            _ctx = ctx;
        }

        public int Count()
        {
            return _ctx.Watches.ToList().Count;
        }

        public Watches CreateWatch(Watches watches)
        {
            _ctx.Attach(watches).State = EntityState.Added;
            _ctx.SaveChanges();
            return watches;
        }

        public void DeleteWatch(int id)
        {
            _ctx.Attach(ReadById(id)).State = EntityState.Deleted;
            _ctx.SaveChanges();
        }

        public Watches ReadById(int id)
        {
            return _ctx.Watches.FirstOrDefault(w => w.Id == id);
        }

        public IEnumerable<Watches> ReadWatches(Filter filter = null)
        {
            if (filter != null)
            {
                return _ctx.Watches.Skip(filter.ItemsPerPage * (filter.CurrentPage - 1)).Take(filter.ItemsPerPage);
            }
            else
            {
                return _ctx.Watches;
            }
        }

        public Watches Update(Watches watchesUpdate)
        {
            _ctx.Attach(watchesUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return watchesUpdate;
        }
    }
}
