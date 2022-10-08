using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carsBackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace carsBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            Car car1 = new Car()
            {
                Make = "Subaru",
                Model = "WRX STI",
                Year = 2017,
                StyleofCar = "Sport",
                Color = "PEARL WHITE",
                Mileage = 22,
                MPG = 20
            };

            Car car2 = new Car()
            {
                Make = "BMW",
                Model = "M4",
                Year = 2019,
                StyleofCar = "Sport",
                Color = "Black",
                Mileage = 12,
                MPG = 18
            };

            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            // Todo: Get all cars from hard coded data
            return cars;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
