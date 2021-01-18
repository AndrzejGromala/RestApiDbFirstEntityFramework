using RestApiDbEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.EmployeeData
{
    public interface ICarData
    {
        List<CarModel> GetCars();

        CarModel GetCar(int id);

        CarModel AddCar(CarModel model);

        void DeleteCar(CarModel model);

        CarModel EditCar(CarModel model);
    }
}
