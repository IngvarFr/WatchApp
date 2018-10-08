using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public Watches AddWatch(Watches watches)
        {
            if (string.IsNullOrEmpty(watches.ProductName))
            {
                throw new InvalidOperationException("Watch needs a Name");
            }
            return _watchRepository.CreateWatch(watches);
        }

        public void DeleteWatch(int id)
        {
            if (id < 1)
            {
                throw new InvalidOperationException("Watch Id needs to be larger then 0");
            }
            _watchRepository.DeleteWatch(id);
        }

        public Watches FindWatchesById(int id)
        {
            return _watchRepository.ReadyById(id);
        }

        public Watches FindWatchesByIdIncludOwners(int id)
        {
            throw new NotImplementedException();
        }

        public List<Watches> FindWatchesType()
        {
            return _watchRepository.ReadWatches()
                .Where(watch => watch.ProductName.Equals(watch.ProductName))
                .ToList();
        }

        public List<Watches> GetFilteredPets(Filter filter)
        {
            if (filter.CurrentPage < 0 || filter.ItemsPerPage < 0)
            {
                throw new InvalidDataException("Current page and Items page must be zero or more");
            }
            if ((filter.CurrentPage - 1 * filter.ItemsPerPage) >= _watchRepository.Count())
            {
                throw new InvalidDataException("Index out of bounds, Curret page is too high");
            }
            return _watchRepository.ReadWatches(filter).ToList();
        }

        public List<Watches> GetWatches()
        {
            return _watchRepository.ReadWatches().ToList();
        }

        public List<Watches> SorWatchesByPrice()
        {
            throw new NotImplementedException();
        }

        public Watches UpdateWatch(Watches watchUpdate)
        {
            var watch = _watchRepository.Update(watchUpdate);
            watch.ProductName = watchUpdate.ProductName;
            watch.ProductDescription = watchUpdate.ProductDescription;
            watch.ProductPicture = watchUpdate.ProductPicture;
            watch.Price = watchUpdate.Price;
            watch.Stock = watchUpdate.Stock;
            return watch;
        }
    }
}
