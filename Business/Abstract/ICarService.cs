using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService:IServiceRepository<Car>
    {
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
