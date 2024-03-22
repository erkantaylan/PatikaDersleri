using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product rental)
        {
            productDal.Delete(rental);
            return new SuccessResult(Messages.ProductDelete);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 02) return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            return new SuccessDataResult<List<Product>>(productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Product>>(productDal.GetAll(p => p.CarId == id), Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitsPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(
                productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailById(int productId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                productDal.GetProductDetails(c => c.ProductId == productId), Messages.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(productDal.GetProductDetails());
        }

        public IResult Update(Product rental)
        {
            productDal.Update(rental);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(productDal.GetAll(p => p.BrandCategoryId == id),
                Messages.Listed);
        }
    }
}