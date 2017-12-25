using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics.Controllers
{
    public class CarDirectoryController : ApiController
    {
        private readonly CarDirectoryRepository _repository;

        public CarDirectoryController(CarDirectoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<CarDirectory>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route]
        public async Task<CarDirectory> Get(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        [Route]
        public async Task Post(CarDirectory bookedCar)
        {
            await _repository.Create(bookedCar);
        }

        [HttpPut]
        [Route]
        public async Task Put(CarDirectory bookedCar)
        {
            await _repository.Update(bookedCar);
        }

        [HttpDelete]
        [Route]
        public async Task Delete(CarDirectory bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}