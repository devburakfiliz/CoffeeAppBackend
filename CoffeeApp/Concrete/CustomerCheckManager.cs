using CoffeeApp.Abstract;
using CoffeeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

     
           
    }
}
