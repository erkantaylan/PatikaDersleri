using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car rental)
        {
            carDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car rental)
        {
            carDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 02) return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            return new SuccessDataResult<List<Car>>(carDal.GetAll(), Messages.CarsListed);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IDataResult<List<Car>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(p => p.CarId == id), Messages.CarsListed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(carDal.Get(p => p.CarId == carId));
        }

        public IDataResult<List<Car>> GetByUnitsPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(p => p.DailyPrice <= max && p.DailyPrice >= min));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailById(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails(c => c.CarId == carId),
                Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrand(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails(c => c.BrandId == brandId),
                Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColor(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails(c => c.ColorId == colorId),
                Messages.CarsListed);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car rental)
        {
            carDal.Update(rental);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}