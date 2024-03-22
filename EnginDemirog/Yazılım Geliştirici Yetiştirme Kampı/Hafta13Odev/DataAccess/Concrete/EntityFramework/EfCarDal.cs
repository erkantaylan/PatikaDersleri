using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using var context = new CarDbContext();
            IQueryable<CarDetailDto> result = from p in context.Cars
                join c in context.Colors on p.ColorId equals c.ColorId
                join d in context.Brands on p.BrandId equals d.BrandId
                select new CarDetailDto
                {
                    CarId = p.CarId,
                    CarName = p.CarName,
                    BrandId = p.BrandId,
                    BrandName = d.BrandName,
                    Model = p.Model,
                    ColorId = p.ColorId,
                    ColorName = c.ColorName,
                    ModelYear = p.ModelYear,
                    DailyPrice = p.DailyPrice,
                    Description = p.Description,
                    CarImages = (from i in context.CarImages
                            where p.CarId == i.CarId
                            select new CarImage
                                { Id = i.Id, CarId = i.CarId, ImagePath = i.ImagePath, Date = i.Date })
                        .ToList()
                };
            return filter == null ? result.ToList() : result.Where(filter).ToList();
        }
    }
}