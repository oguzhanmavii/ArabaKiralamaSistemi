using Core.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
   public interface IServiceRepository<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IDataResult<T> GetById(int id);
        IResult Update(T entity);
        IResult Delete(T entity);
    }

 
}
