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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using var context = new CarDbContext();
            IQueryable<RentalDetailDto> result = from r in context.Rentals
                join c in context.Cars on r.CarId equals c.CarId
                join b in context.Brands on c.BrandId equals b.BrandId
                join cl in context.Colors
                    on c.ColorId equals cl.ColorId
                join u in context.Users
                    on r.UserId equals u.Id
                select new RentalDetailDto
                {
                    CarId = c.CarId,
                    BrandId = b.BrandId,
                    BrandName = b.BrandName,
                    ColorId = cl.ColorId,
                    ColorName = cl.ColorName,
                    ModelName = c.Model,
                    RentalId = r.Id,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate,
                    Amount = r.Amount,
                    UserId = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                };

            return filter == null ? result.ToList() : result.Where(filter).ToList();
        }
    }
}