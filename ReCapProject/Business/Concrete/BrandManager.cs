using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Result Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccessResult(Messages.AddBrandMessage);
        }

        public Result Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.DeleteBrandMessage);
        }

        public DataResult<Brand> Get(int id)
        {
            
            Brand brand = _brandDal.Get(p => p.BrandId == id);

            if (brand == null)
            {
                return new ErrorDataResult<Brand>(Messages.GetErrorBrandMessage);
            }
            else
            {
                return   new SuccessDataResult<Brand>(brand, Messages.GetSuccessBrandMessage);
            }
            



        }

        public DataResult<List<Brand>> GetAll()
        {
            List<Brand> brands =  _brandDal.GetAll();
            if (brands == null)
            {
                return new ErrorDataResult<List<Brand>>(Messages.GetErrorBrandMessage);
            }
            else
            {
                return new SuccessDataResult<List<Brand>>(brands, Messages.GetSuccessBrandMessage);
            }

        }

        public Result Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.EditBrandMessage);
        }
    }
}