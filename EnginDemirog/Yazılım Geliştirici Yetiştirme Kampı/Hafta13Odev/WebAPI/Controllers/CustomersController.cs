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
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Customer>> result = _customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            IDataResult<Customer> result = _customerService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            IResult result = _customerService.Add(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            IResult result = _customerService.Update(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            IResult result = _customerService.Delete(customer);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetails")]
        public IActionResult GetCustomersDetails()
        {
            IDataResult<List<CustomerDetailDto>> result = _customerService.GetCustomersDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetailbyid")]
        public IActionResult GetCustomersDetailById(int customerId)
        {
            IDataResult<List<CustomerDetailDto>> result = _customerService.GetCustomersDetailById(customerId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}