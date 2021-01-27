using Business.Abstract;
using Entities.Concreate;
using Services.Concreate;
using System;

namespace Business.Concreate
{
    public class CustomerManager : ICustomerManager
    {
        public bool Add(Customer customer)
        {
            Console.WriteLine("Customer Manager");
            TCNumberServices services = new TCNumberServices();
            bool status = services.CheckIt(customer);
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