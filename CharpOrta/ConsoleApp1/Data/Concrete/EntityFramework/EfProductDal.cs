﻿using Core.DataAccess.EntityFramework;
using Data.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Data.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>,IProductDal
    {

    }
}
