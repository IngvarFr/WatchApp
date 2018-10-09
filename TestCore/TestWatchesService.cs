using WatchApp.Core.ApplicationServices;
using WatchApp.Core.DomainServices;
using Xunit;
using Moq;
using WatchApp.Core.ApplicationServices.Services;
using WatchApp.Core.Entity;
using System;
using System.IO;

namespace TestCore
{
    public class TestWatchesService
    {
        [Fact]
        public void TestAddWatchWithoutName()
        {
            var watchRepo = new Mock<IWatchesRepository>();
            IWatchesServices service = new WatchesService(watchRepo.Object);
            var watch = new Watches()
            { ProductDescription = "Good watch", Price = 200, Stock = 20 };
            Exception ex = Assert.Throws<InvalidOperationException>
                (() => service.AddWatch(watch));
            Assert.Equal("Watch needs a Name", ex.Message);
        }

        [Fact]
        public void TestDeleteWatchBadId()
        {
            var watchRepo = new Mock<IWatchesRepository>();
            IWatchesServices service = new WatchesService(watchRepo.Object);
            Exception ex = Assert.Throws<InvalidOperationException>
                (() => service.DeleteWatch(0));
            Assert.Equal("Watch Id needs to be larger then 0", ex.Message);
        }

        [Fact]
        public void TestFilterInvalidData()
        {
            var watchRepo = new Mock<IWatchesRepository>();
            IWatchesServices service = new WatchesService(watchRepo.Object);
            Exception ex = Assert.Throws<InvalidDataException>(() => service.GetFilteredWatches(new Filter() { CurrentPage = 0, ItemsPerPage = 0 }));
            Assert.Equal("Current page and Items per page must be above zero", ex.Message);
        }

        [Fact]
        public void TestFilterOutOfBounds()
        {
            var watchRepo = new Mock<IWatchesRepository>();
            IWatchesServices service = new WatchesService(watchRepo.Object);
            Exception ex = Assert.Throws<InvalidDataException>(() => service.GetFilteredWatches(new Filter() { CurrentPage = 10, ItemsPerPage = 10 }));
            Assert.Equal("Index out of bounds, Curret page is too high", ex.Message);
        }
    }
}
