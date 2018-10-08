﻿using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.DomainServices;
using WatchApp.Core.Entity;

namespace WatchApp.Core.ApplicationServices.Services
{
    public class WatchesService : IWatchesServices
    {
        readonly IWatchesRepository _watchRepository;

        public WatchesService(IWatchesRepository watchRepository)
        {
            _watchRepository = watchRepository;
        }

        public Watches AddPet(Watches pet)
        {
            throw new NotImplementedException();
        }

        public void DeleteWatch(int id)
        {
            throw new NotImplementedException();
        }

        public Watches FindWatchesById(int id)
        {
            throw new NotImplementedException();
        }

        public Watches FindWatchesByIdIncludOwners(int id)
        {
            throw new NotImplementedException();
        }

        public List<Watches> FindWatchesType()
        {
            throw new NotImplementedException();
        }

        public List<Watches> GetFilteredPets(Filter filter)
        {
            throw new NotImplementedException();
        }

        public List<Watches> GetWatches()
        {
            throw new NotImplementedException();
        }

        public Watches GetWatchesInstance()
        {
            throw new NotImplementedException();
        }

        public List<Watches> SorWatchesByPrice()
        {
            throw new NotImplementedException();
        }

        public Watches UpdateWatch(Watches petUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
