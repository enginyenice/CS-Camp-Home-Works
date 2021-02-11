using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Result Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(Messages.AddColorMessage);
        }

        public Result Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.DeleteColorMessage);
        }

        public DataResult<Color> Get(int id)
        {
            Color color =  _colorDal.Get(p => p.ColorId == id);
            if(color == null)
            {
                return new ErrorDataResult<Color>(Messages.GetErrorColorMessage);
            } else
            {
                return new SuccessDataResult<Color>(color,Messages.GetErrorColorMessage);
            }
        }

        public DataResult<List<Color>> GetAll()
        {
            List<Color> colors =  _colorDal.GetAll();
            if (colors == null)
            {
                return new ErrorDataResult<List<Color>>(Messages.GetErrorColorMessage);
            }
            else
            {
                return new SuccessDataResult<List<Color>>(colors, Messages.GetErrorColorMessage);
            }
        }

        public Result Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.EditColorMessage);
        }
    }
}