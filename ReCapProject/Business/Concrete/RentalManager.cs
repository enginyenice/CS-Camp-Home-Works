using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public Result Add(Rental entity)
        {
            var isDeliveryControl = IsDelivery(entity.CarId);
            if (isDeliveryControl.Success)
            {
                _rentalDal.Add(entity);
                return new SuccessResult(Messages.AddRentalMessage);
            }
            else
            {
                return new ErrorResult(isDeliveryControl.Message);
            }
        }

        public Result Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.DeleteRentalMessage);
        }

        public DataResult<Rental> Get(int id)
        {
            Rental rental = _rentalDal.Get(p => p.Id == id);
            if (rental == null)
            {
                return new ErrorDataResult<Rental>(Messages.GetErrorRentalMessage);
            }
            else
            {
                return new SuccessDataResult<Rental>(rental, Messages.GetSuccessRentalMessage);
            }
        }

        public DataResult<List<Rental>> GetAll()
        {
            List<Rental> rentals = _rentalDal.GetAll();
            if (rentals.Count == 0)
            {
                return new ErrorDataResult<List<Rental>>(Messages.GetErrorRentalMessage);
            }
            else
            {
                return new SuccessDataResult<List<Rental>>(rentals, Messages.GetSuccessRentalMessage);
            }
        }

        public DataResult<bool> IsDelivery(int carId)
        {
            Rental isDeliveryCar = _rentalDal.Get(p => p.CarId == carId && p.ReturnDate == null);
            if (_rentalDal.Get(p => p.CarId == carId && p.ReturnDate == null) != null)
                return new ErrorDataResult<bool>(false, Messages.CarNotAvaible);
            else
                return new SuccessDataResult<bool>(true, Messages.CarAvaible);
        }

        public Result Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.EditRentalMessage);
        }
    }
}