using Entities.Concreate;

namespace Business.Abstract
{
    internal interface ICustomerManager
    {
        bool Add(Customer customer);
    }
}