﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService:IGenelService<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
