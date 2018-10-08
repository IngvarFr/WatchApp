using System;
using System.Collections.Generic;
using System.Text;

namespace WatchApp.Core.Entity
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Watches> Watches { get; set; }
    }
}
