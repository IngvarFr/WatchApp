using System;
using System.Collections.Generic;
using System.Text;
using WatchApp.Core.Entity;

namespace WatchApp.Core.ApplicationService
{
    public interface ICustomerService
    {
        Customers GetCustomersInstance();

        List<Customers> GetCustomers();

        Customers AddCustomer(Customers customers);

        void DeleteCustomer(int id);

        List<Customers> FindCustomerName();

        Customers FindCustomerById(int id);

        Customers FindCustomerByIdIncludePets(int id);

        Customers UpdateOwner(Customers customerUpdate);
    }
}
