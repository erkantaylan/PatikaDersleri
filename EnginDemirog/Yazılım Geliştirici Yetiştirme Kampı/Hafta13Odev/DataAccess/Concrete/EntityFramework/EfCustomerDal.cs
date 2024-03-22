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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using var context = new CarDbContext();
            IQueryable<CustomerDetailDto> result = from p in context.Customers
                join c in context.Users on p.UserId equals c.Id
                select new CustomerDetailDto
                {
                    CustomerId = p.CustomerId,
                    CompanyName = p.CompanyName,
                    FirstName = c.FirstName,
                    LastName = c.LastName
                };
            return filter == null ? result.ToList() : result.Where(filter).ToList();
        }
    }
}