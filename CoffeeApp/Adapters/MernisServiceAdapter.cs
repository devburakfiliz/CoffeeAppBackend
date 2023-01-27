using CoffeeApp.Abstract;
using CoffeeApp.Entities;
using ServiceReference12;
using System;
using System.Collections.Generic;
using System.Text;
using static ServiceReference12.KPSPublicSoapClient;

namespace CoffeeApp.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

        }
    }
}
