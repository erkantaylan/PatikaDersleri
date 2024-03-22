using System;
using System.Collections.Generic;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var productManager = new BrandManager(new EfBrandDal());
            IDataResult<List<Brand>> result = productManager.GetAll();
            if (result.Success)
                foreach (Brand product in result.Data)
                    Console.WriteLine(product.BrandId + " / " + product.BrandName);
            else
                Console.WriteLine(result.Message);
            //CarTest();
            //ProductTest();
            Console.ReadKey();
        }

        private static void CarTest()
        {
            var carManager = new CarManager(new EfCarDal());
            IDataResult<List<CarDetailDto>> result = carManager.GetCarDetails();
            if (result.Success)
                foreach (CarDetailDto product in result.Data)
                    Console.WriteLine(product.CarName + " / " + product.DailyPrice);
            else
                Console.WriteLine(result.Message);
        }

        private static void ProductTest()
        {
            var productManager = new ProductManager(new EfProductDal());
            IDataResult<List<ProductDetailDto>> result = productManager.GetProductDetails();
            if (result.Success)
                foreach (ProductDetailDto product in result.Data)
                    Console.WriteLine(product.ProductName + " / " + product.CarName);
            else
                Console.WriteLine(result.Message);
        }
    }
}