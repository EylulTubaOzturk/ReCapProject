using ConsoleUI;
using System;
using System.Collections.Generic;

namespace Console
{
    internal class CarManager
    {
        private InMemoryCarDal ınMemoryCarDal;

        public CarManager(InMemoryCarDal ınMemoryCarDal)
        {
            this.ınMemoryCarDal = ınMemoryCarDal;
        }

        internal IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> GetById(int v)
        {
            throw new NotImplementedException();
        }

        internal void Delete(Car car2)
        {
            throw new NotImplementedException();
        }

        internal void Update(Car car2)
        {
            throw new NotImplementedException();
        }
    }
}