using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiDbEntityFramework.EmployeeData;
using RestApiDbEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarData _carData;
        public CarsController(ICarData carData)
        {
            _carData = carData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCars()
        {
            return Ok(_carData.GetCars());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCars(int id)
        {
            var car = _carData.GetCar(id);

            if(car != null)
            {
                return Ok(car);
            }
            return NotFound($"The car with id: {id} was not found!");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCar(CarModel model) 
        {
            _carData.AddCar(model);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host
                + HttpContext.Request.Path + "/" + model.Id, model);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _carData.GetCar(id);

            if(car != null)
            {
                _carData.DeleteCar(car);
                return Ok();
            }
            return NotFound($"The car with id: {id} was not found!");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult EditCar(int id, CarModel model)
        {
            var existingCar = _carData.GetCar(id);
            if (existingCar != null)
            {
                model.Id = existingCar.Id;
                _carData.EditCar(model);
                
            }
            return Ok();
        }

    }
}
