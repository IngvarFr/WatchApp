using System;
using System.Collections.Generic;
using System.Text;

namespace WatchApp.Core.Entity
{
    public class Watches
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPicture { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}
