﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // coklu işlem vs yapmak için 
        T Get(Expression<Func<T, bool>> filter); //Tek kişi için hesaplarınız vs getirmek için filtre zorunludur.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}