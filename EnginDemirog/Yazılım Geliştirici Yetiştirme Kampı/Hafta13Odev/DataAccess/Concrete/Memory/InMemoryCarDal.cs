﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.Memory
{
    public class InMemoryCarDal : ICarDal
    {
        private readonly List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car
                {
                    CarId = 1, BrandId = 1, Model = "Corsa", ColorId = 1, ModelYear = 2009, DailyPrice = 450,
                    Description = "Yeni Temiz"
                },
                new Car
                {
                    CarId = 2, BrandId = 1, Model = "Corsa1", ColorId = 2, ModelYear = 2010, DailyPrice = 300,
                    Description = "Yeni Temiz"
                },
                new Car
                {
                    CarId = 3, BrandId = 2, Model = "C30", ColorId = 2, ModelYear = 2020, DailyPrice = 200,
                    Description = "Yeni Temiz"
                },
                new Car
                {
                    CarId = 4, BrandId = 2, Model = "C20", ColorId = 3, ModelYear = 2020, DailyPrice = 1500,
                    Description = "Yeni Temiz"
                },
                new Car
                {
                    CarId = 5, BrandId = 2, Model = "C10", ColorId = 4, ModelYear = 2022, DailyPrice = 2500,
                    Description = "Yeni Temiz"
                }
            };
        }

        public InMemoryCarDal(List<Car> cars)
        {
            this.cars = cars;
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = cars.SingleOrDefault(x => x.CarId == car.CarId);
            cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = cars.SingleOrDefault(x => x.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.Model = car.Model;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
            carUpdate.DailyPrice = car.DailyPrice;
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAllBrandCategoryId(int brandId)
        {
            return cars.Where(x => x.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}