using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Result Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult(Messages.AddCustomerMessage);
        }

        public Result Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult(Messages.DeleteCustomerMessage);
        }

        public DataResult<Customer> Get(int id)
        {
            Customer customer = _customerDal.Get(p => p.Id == id);
            if(customer == null)
            {
                return new ErrorDataResult<Customer>(Messages.GetErrorCustomerMessage);
            } else
            {
                return new SuccessDataResult<Customer>(customer, Messages.GetSuccessCustomerMessage);
            }
        }

        public DataResult<List<Customer>> GetAll()
        {
            List<Customer> customers = _customerDal.GetAll();
            if (customers.Count == 0)
            {
                return new ErrorDataResult<List<Customer>>(Messages.GetErrorCustomerMessage);
            }
            else
            {
                return new SuccessDataResult<List<Customer>>(customers, Messages.GetSuccessCustomerMessage);
            }
        }

        public Result Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult(Messages.EditCustomerMessage);
        }
    }
}
