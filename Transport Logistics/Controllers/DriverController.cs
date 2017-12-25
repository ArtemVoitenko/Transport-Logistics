using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics.Controllers
{
    public class DriverController : ApiController
    {
        private readonly DriverRepository _repository;

        public DriverController(DriverRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<Driver>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route]
        public async Task<Driver> Get(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        [Route]
        public async Task Post(Driver bookedCar)
        {
            await _repository.Create(bookedCar);
        }

        [HttpPut]
        [Route]
        public async Task Put(Driver bookedCar)
        {
            await _repository.Update(bookedCar);
        }

        [HttpDelete]
        [Route]
        public async Task Delete(Driver bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}