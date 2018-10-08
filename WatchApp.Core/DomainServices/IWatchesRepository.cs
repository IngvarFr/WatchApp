using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.DomainServices
{
    public interface IWatchesRepository
    {
        IEnumerable<Watches> ReadPets(Filter filter = null);

        Watches CreatePet(Watches watches);

        void DeleteWatch(int id);

        Watches ReadyById(int id);

        Watches Update(Watches watchesUpdate);

        Watches FindWatchesByIdIncludeOwners(int id);

        int Count();
    }
}
