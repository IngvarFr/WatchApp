using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.ApplicationServices
{
    public interface IWatchesServices
    {
        List<Watches> GetWatches();

        Watches AddWatch(Watches watches);

        void DeleteWatch(int id);

        List<Watches> SortWatchesByPrice();

        List<Watches> FindWatchesType();

        Watches FindWatchesById(int id);

        Watches FindWatchesByIdIncludOwners(int id);

        Watches UpdateWatch(Watches watchUpdate);

        List<Watches> GetFilteredWatches(Filter filter);
    }
}
