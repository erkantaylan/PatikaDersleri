using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService brandService;

        public BrandsController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Brand>> result = brandService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            IResult result = brandService.Add(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            IResult result = brandService.Delete(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            IResult result = brandService.Update(brand);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}