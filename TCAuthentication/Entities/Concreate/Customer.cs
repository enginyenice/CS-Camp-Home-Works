using Entities.Abstract;

namespace Entities.Concreate
{
    public class Customer : ICustomer
    {
        public int id { get; set; }
        public long TCNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int birthYear { get; set; }
    }
}