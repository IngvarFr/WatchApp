using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.ApplicationServices
{
    interface IWatchesServices
    {
        List<Watches> GetWatches();

        Watches AddWatch(Watches watches);

        void DeleteWatch(int id);

        List<Watches> SorWatchesByPrice();

        List<Watches> FindWatchesType();

        Watches FindWatchesById(int id);

        Watches FindWatchesByIdIncludOwners(int id);

        Watches UpdateWatch(Watches watchUpdate);

        List<Watches> GetFilteredPets(Filter filter);
    }
}
