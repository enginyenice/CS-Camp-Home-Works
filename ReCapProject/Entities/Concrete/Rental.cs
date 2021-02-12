using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        //Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
        public int Id { get; set; }

        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; } //Araba teslim edilmemişse ReturnDate null'dır.
    }
}