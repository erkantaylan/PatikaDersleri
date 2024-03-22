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
    public class RentalsController : ControllerBase
    {
        private readonly IRentalService rentalService;

        public RentalsController(IRentalService rentalService)
        {
            this.rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Rental>> result = rentalService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            IDataResult<Rental> result = rentalService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getrentaldetailbycarid")]
        public IActionResult GetRentalDetailByCarId(int carId)
        {
            IDataResult<List<RentalDetailDto>> result = rentalService.GetRentalDetailByCarId(carId);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getrentaldetailbyuserid")]
        public IActionResult GetRentalDetailsByUserId(int userId)
        {
            IDataResult<List<RentalDetailDto>> result = rentalService.GetRentalDetailsByUserId(userId);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int id)
        {
            IDataResult<List<Rental>> result = rentalService.GetByCarId(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            IResult result = rentalService.Add(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            IResult result = rentalService.Update(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            IResult result = rentalService.Delete(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("details")]
        public IActionResult GetRentalDetails()
        {
            IDataResult<List<RentalDetailDto>> result = rentalService.GetRentalDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}