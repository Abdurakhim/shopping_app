using Shopping_app.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> getFavCars { get; }

        Car getObjectCar(int carId);
    }
}
