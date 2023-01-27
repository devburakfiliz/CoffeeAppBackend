using CoffeeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
