using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Car>> result = _carService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            IResult result = _carService.Add(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            IResult result = _carService.Update(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            IResult result = _carService.Delete(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }


        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            IDataResult<List<CarDetailDto>> result = _carService.GetCarDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarDetailsByColor(int colorId)
        {
            IDataResult<List<CarDetailDto>> result = _carService.GetCarDetailsByColor(colorId);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("carsDetailsByBrandId")]
        public IActionResult GetCarDetailsByBrand(int brandId)
        {
            IDataResult<List<CarDetailDto>> result = _carService.GetCarDetailsByBrand(brandId);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetCarDetailById")]
        public IActionResult GetCarDetailById(int carId)
        {
            IDataResult<List<CarDetailDto>> result = _carService.GetCarDetailById(carId);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        //[HttpGet("getfilter")]
        //public IActionResult GetCarDetailBrandAndColorId(int brandId, int colorId)
        //{
        //    var result = _carService.GetCarDetailsFilter(brandId, colorId);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}

        //[HttpPost("addtransactiontest")]
        //public IActionResult AddTrancactionTest(Car car)
        //{
        //    var result = _carService.AddTransactionTest(car);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}