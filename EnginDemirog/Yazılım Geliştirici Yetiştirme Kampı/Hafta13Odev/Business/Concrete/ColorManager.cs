using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal colorDal;

        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }

        public IResult Add(Color rental)
        {
            colorDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color rental)
        {
            colorDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(colorDal.GetAll(), Messages.Added);
        }

        public IDataResult<List<Color>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Color>>(colorDal.GetAll(p => p.ColorId == id), Messages.Listed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(colorDal.Get(p => p.ColorId == id), Messages.Listed);
        }

        public IResult Update(Color rental)
        {
            colorDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}