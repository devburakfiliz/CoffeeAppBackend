using CoffeeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServiceReference12;

namespace CoffeeApp.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
