using Business.Abstract;
using Entities.Concreate;
using Services.Concreate;
using System;

namespace Business.Concreate
{
    public class CustomerManager : ICustomerManager
    {
        TCNumberServices _TCNumberServices;

        public CustomerManager(TCNumberServices tCNumberServices)
        {
            _TCNumberServices = tCNumberServices;
        }

        public bool Add(Customer customer)
        {
            Console.WriteLine("Customer Manager");
            bool status = _TCNumberServices.CheckIt(customer);
            if (status)
            {
                Console.WriteLine("Customer Add");
            }
            else
            {
                Console.WriteLine("Credentials are incorrect.");
            }
            return status;
        }
    }
}