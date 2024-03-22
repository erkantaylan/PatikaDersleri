using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService : IService<Customer>
    {
        IDataResult<List<CustomerDetailDto>> GetCustomersDetailById(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomersDetails();
    }
}