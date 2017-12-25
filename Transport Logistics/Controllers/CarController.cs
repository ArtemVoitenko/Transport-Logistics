using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics
{
    public class CarController : ApiController
    {
        private readonly CarRepository _repository;

        public CarController(CarRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<Car>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route]
        public async Task<Car> Get(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        [Route]
        public async Task Post(Car bookedCar)
        {
            await _repository.Create(bookedCar);
        }

        [HttpPut]
        [Route]
        public async Task Put(Car bookedCar)
        {
            await _repository.Update(bookedCar);
        }

        [HttpDelete]
        [Route]
        public async Task Delete(Car bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}