using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this.rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Rental rental)
        {
            rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Rental>>(rentalDal.GetAll(r => r.UserId == id));
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetByAmountPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Rental>>(rentalDal.GetAll(p => p.Amount <= max && p.Amount >= min));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(rentalDal.GetRentalDetails());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsById(int id)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(rentalDal.GetRentalDetails(r => r.CarId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsByUserId(int userId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(rentalDal.GetRentalDetails(r => r.UserId == userId));
        }

        public IResult Update(Rental rental)
        {
            rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailByCarId(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(rentalDal.GetRentalDetails(r => r.CarId == carId));
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(rentalDal.GetAll(p => p.CarId == carId));
        }
    }
}