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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Customer>> result = customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            IDataResult<Customer> result = customerService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            IResult result = customerService.Add(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            IResult result = customerService.Update(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            IResult result = customerService.Delete(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetails")]
        public IActionResult GetCustomersDetails()
        {
            IDataResult<List<CustomerDetailDto>> result = customerService.GetCustomersDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetailbyid")]
        public IActionResult GetCustomersDetailById(int customerId)
        {
            IDataResult<List<CustomerDetailDto>> result = customerService.GetCustomersDetailById(customerId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}