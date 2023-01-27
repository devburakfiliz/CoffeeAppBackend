using CoffeeApp.Abstract;
using CoffeeApp.Adapters;
using CoffeeApp.Concrete;
using CoffeeApp.Entities;
using System;

namespace CoffeeApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1996,1,14), FirstName="Burak",LastName="Filiz",NationalityId="35194973090"});
            Console.ReadLine();
        }
    }
}
