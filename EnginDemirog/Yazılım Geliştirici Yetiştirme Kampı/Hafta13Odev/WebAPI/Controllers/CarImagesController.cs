using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            this.carImageService = carImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = "Image")] IFormFile formFile, [FromForm] CarImage carImage)
        {
            IResult result = carImageService.Add(carImage, formFile);
            if (result.Success) return Ok(carImage);
            return BadRequest(result);
        }

        [HttpPost("updated")]
        public IActionResult Update([FromForm(Name = "Image")] IFormFile formFile, [FromForm] CarImage carImage)
        {
            IResult result = carImageService.Update(carImage, formFile);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            IResult result = carImageService.Delete(carImage);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<CarImage>> result = carImageService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            IDataResult<CarImage> result = carImageService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            IDataResult<List<CarImage>> result = carImageService.GetByCarId(carId);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}