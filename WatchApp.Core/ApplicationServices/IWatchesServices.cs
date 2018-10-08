using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.ApplicationServices
{
    interface IWatchesServices
    {
        Watches GetWatchesInstance();

        List<Watches> GetWatches();

        Watches AddPet(Watches pet);

        void DeleteWatch(int id);

        List<Watches> SorWatchesByPrice();

        List<Watches> FindWatchesType();

        Watches FindWatchesById(int id);

        Watches FindWatchesByIdIncludOwners(int id);

        Watches UpdateWatch(Watches petUpdate);

        List<Watches> GetFilteredPets(Filter filter);
    }
}
