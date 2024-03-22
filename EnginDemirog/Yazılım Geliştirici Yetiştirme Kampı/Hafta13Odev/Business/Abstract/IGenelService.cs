using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetAllById(int id);
        IDataResult<T> GetById(int id);
        IResult Add(T rental);
        IResult Delete(T rental);
        IResult Update(T rental);
    }
}