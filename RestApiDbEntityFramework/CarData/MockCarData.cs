using RestApiDbEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.EmployeeData
{
    public class MockCarData : ICarData
    {

        private List<CarModel> cars = new List<CarModel>()
        {
            new CarModel()
            {
                Id = 1,
                MakeModel = "Merc",
                Engine = "2L",
                Transmission = "manual",
                Color = "black",
                Year = "2020"
            },
            new CarModel()
            {
                Id = 2,
                MakeModel = "BMW",
                Engine = "4L",
                Transmission = "automatic",
                Color = "silver",
                Year = "2018"
            }
        };

    
    public CarModel AddCar(CarModel model)
        {
            
            cars.Add(model);

            return model;
        }

        public void DeleteCar(CarModel model)
        {
            cars.Remove(model);
        }

        public CarModel EditCar(CarModel model)
        {
            var existingCar = GetCar(model.Id);
            existingCar.MakeModel = model.MakeModel;
            existingCar.Engine = model.Engine;
            existingCar.Transmission = model.Transmission;
            existingCar.Color = model.Color;
            existingCar.Year = model.Year;

            return existingCar;
        }

        public CarModel GetCar(int id)
        {
            return cars.SingleOrDefault(x => x.Id == id);
        }

        public List<CarModel> GetCars()
        {
            return cars;
        }
    }
}
