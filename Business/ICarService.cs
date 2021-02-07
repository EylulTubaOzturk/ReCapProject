using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll { get; }
        List<Car> GetById(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}