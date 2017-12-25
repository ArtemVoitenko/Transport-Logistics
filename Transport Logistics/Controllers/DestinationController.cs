using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics.Controllers
{
    public class DestinationController : ApiController
    {
        private readonly DestinationRepository _repository;

        public DestinationController(DestinationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<Destination>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route]
        public async Task<Destination> Get(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        [Route]
        public async Task Post(Destination bookedCar)
        {
            await _repository.Create(bookedCar);
        }

        [HttpPut]
        [Route]
        public async Task Put(Destination bookedCar)
        {
            await _repository.Update(bookedCar);
        }

        [HttpDelete]
        [Route]
        public async Task Delete(Destination bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}