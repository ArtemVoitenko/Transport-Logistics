using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly CustomerRepository _repository;

        public CustomerController(CustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route]
        public async Task<Customer> Get(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPost]
        [Route]
        public async Task Post(Customer bookedCar)
        {
            await _repository.Create(bookedCar);
        }

        [HttpPut]
        [Route]
        public async Task Put(Customer bookedCar)
        {
            await _repository.Update(bookedCar);
        }

        [HttpDelete]
        [Route]
        public async Task Delete(Customer bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}