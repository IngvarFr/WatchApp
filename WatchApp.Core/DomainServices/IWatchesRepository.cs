using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.DomainServices
{
    public interface IWatchesRepository
    {
        IEnumerable<Watches> ReadWatches(Filter filter = null);

        Watches CreateWatch(Watches watches);

        void DeleteWatch(int id);

        Watches ReadById(int id);

        Watches Update(Watches watchesUpdate);

        int Count();
    }
}
