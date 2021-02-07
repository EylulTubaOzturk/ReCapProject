using System.Collections.Generic;

namespace Business
{
    public interface ICarDal
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetById(int ıd);
    }
}