﻿using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IDataResult<List<Product>> result = productService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            IDataResult<Product> result = productService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            IResult result = productService.Add(product);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            IResult result = productService.Update(product);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Product product)
        {
            IResult result = productService.Delete(product);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetails")]
        public IActionResult GetCarDetails()
        {
            IDataResult<List<ProductDetailDto>> result = productService.GetProductDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetailbyid")]
        public IActionResult GetCustomerDetailById(int customerId)
        {
            IDataResult<List<ProductDetailDto>> result = productService.GetProductDetailById(customerId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}