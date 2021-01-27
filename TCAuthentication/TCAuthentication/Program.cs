using Business.Concreate;
using Entities.Concreate;
using System;

namespace TCAuthentication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Services.Concreate.TCNumberServices());
            Customer customer = new Customer();
            customer.TCNumber = 34880000000; //long
            customer.firstName = "Engin"; // string
            customer.lastName = "Yenice"; // string
            customer.birthYear = 1998; // integer
            bool result = customerManager.Add(customer);
            if (result)
            {
                Console.WriteLine("Program.cs : Success");
            }
            else
            {
                Console.WriteLine("Program.cs : Error");
            }
        }
    }
}