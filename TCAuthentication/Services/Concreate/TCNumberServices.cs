using Entities.Concreate;
using Services.Abstract;
using System;

namespace Services.Concreate
{
    public class TCNumberServices : ITCNumberServices
    {
        public bool CheckIt(Customer customer)
        {
            bool check = false;
            try
            {
                TCAuth.KPSPublicSoapClient client = new TCAuth.KPSPublicSoapClient(TCAuth.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var result = client.TCKimlikNoDogrulaAsync(customer.TCNumber, customer.firstName, customer.lastName, customer.birthYear).Result;
                Console.WriteLine("TC Auth Services: " + result.Body.TCKimlikNoDogrulaResult);
                check = result.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception)
            {
                Console.WriteLine("TC Auth Services: An error occurred while connecting to the service");
                check = false;
            }
            return check;
        }
    }
}