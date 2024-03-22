using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(customerDal.GetAll(), Messages.CustomerListed);
        }

        public IDataResult<List<Customer>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Customer>>(customerDal.GetAll(p => p.CustomerId == id));
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(customerDal.Get(c => c.UserId == id), Messages.CustomerListed);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomersDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(customerDal.GetCustomerDetails(), Messages.Listed);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomersDetailById(int customerId)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(
                customerDal.GetCustomerDetails(c => c.CustomerId == customerId), Messages.Listed);
        }

        public IResult Update(Customer customer)
        {
            customerDal.Update(customer);
            return new SuccessResult(Messages.Updated);
        }
    }
}