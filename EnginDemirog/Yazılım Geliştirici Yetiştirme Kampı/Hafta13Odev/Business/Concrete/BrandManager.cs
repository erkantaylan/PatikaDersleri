using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            this.brandDal = brandDal;
        }

        public IResult Add(Brand rental)
        {
            brandDal.Add(rental);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand rental)
        {
            brandDal.Delete(rental);
            return new SuccessResult(Messages.BrandDelete);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(brandDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Brand>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Brand>>(brandDal.GetAll(p => p.BrandId == id), Messages.Listed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(brandDal.Get(p => p.BrandId == id), Messages.Listed);
        }

        public IResult Update(Brand rental)
        {
            brandDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}