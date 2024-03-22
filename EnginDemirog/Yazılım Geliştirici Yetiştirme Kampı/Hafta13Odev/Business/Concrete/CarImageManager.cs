using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac.Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Aspects.Caching;
using Core.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            this.carImageDal = carImageDal;
        }

        [SecuredOperation("car.add,admin")]
        public IResult Add(CarImage carImage, IFormFile formFile)
        {
            IResult result = BusinessRules.Run(
                CheckCarImageCount(carImage.CarId));
            if (result != null) return result;
            IResult imageResult = FileHelper.Add(formFile);
            if (!imageResult.Success) return new ErrorResult();
            carImage.ImagePath = imageResult.Message;
            carImage.Date = DateTime.Now;
            carImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Update(CarImage carImage, IFormFile formFile)
        {
            CarImage isImage = carImageDal.Get(c => c.CarId == carImage.Id);
            if (isImage == null) return new ErrorResult(Messages.ImageNotFound);

            IResult updated = FileHelper.Update(isImage.ImagePath, formFile);
            if (!updated.Success) return new ErrorResult(Messages.ImageError);
            carImage.ImagePath = updated.Message;
            carImageDal.Update(carImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        public IResult Delete(CarImage carImage)
        {
            CarImage delete = carImageDal.Get(c => c.CarId == carImage.Id);
            if (carImage == null) return new ErrorResult(Messages.ImageNotFound);
            FileHelper.Delete(delete.ImagePath);
            carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(carImageDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(carImageDal.Get(c => c.CarId == id));
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            List<CarImage> result = carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count > 0) return new SuccessDataResult<List<CarImage>>(result);
            var images = new List<CarImage>();
            images.Add(new CarImage { CarId = 0, Id = 0, ImagePath = "/images/defaultt.jpg" });
            return new SuccessDataResult<List<CarImage>>(images);
        }

        //business rules
        public IResult CheckCarImageCount(int carId)
        {
            List<CarImage> result = carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count > 5) return new ErrorResult(Messages.CarCheckImageLimited);
            return new SuccessResult();
        }
    }
}