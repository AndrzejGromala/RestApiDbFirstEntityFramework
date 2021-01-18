using RestApiDbEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.EmployeeData
{
    public class SqlCarData : ICarData
    {
        private CarContext _carContext;

        public SqlCarData(CarContext carContext)
        {
            _carContext = carContext;
        }

        public CarModel AddCar(CarModel model)
        {
            _carContext.Cars.Add(model);
            _carContext.SaveChanges();
            return model;
        }

        public void DeleteCar(CarModel model)
        {
            _carContext.Cars.Remove(model);
            _carContext.SaveChanges();
        }

        public CarModel EditCar(CarModel model)
        {
            var existingCar = _carContext.Cars.Find(model.Id);
            if(existingCar != null) //the code below is required to track the entity to the SQLServer
            {
                existingCar.MakeModel = model.MakeModel;
                existingCar.Engine = model.Engine;
                existingCar.Transmission = model.Transmission;
                existingCar.Color = model.Color;
                existingCar.Year = model.Year;
                _carContext.Cars.Update(existingCar);
                _carContext.SaveChanges();
            }
            return existingCar;
        }

        public CarModel GetCar(int id)
        {
            var employee = _carContext.Cars.Find(id);
            return employee;
        }

        public List<CarModel> GetCars()
        {
            return _carContext.Cars.ToList();
        }
    }
}
