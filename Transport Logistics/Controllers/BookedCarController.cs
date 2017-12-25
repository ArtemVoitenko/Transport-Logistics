using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Transport_Logistics.Entities;
using Transport_Logistics.Repositories;

namespace Transport_Logistics.Controllers
{
    [RoutePrefix("/api/booked-car")]
    public class BookedCarController : ApiController
    {
        private readonly BookedCarsRepository _repository;

        public BookedCarController(BookedCarsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route]
        public async Task<IEnumerable<BookedCar>> Get()
        {
            return await _repository.GetAll();
        }
        
        [HttpGet]
        [Route]
        public async Task<BookedCar> Get(Guid id)
        {
            return await _repository.GetById(id);
        }
        
        [HttpPost]
        [Route]
        public async Task Post(BookedCar bookedCar)
        {
            await _repository.Create(bookedCar);
        }
        
        [HttpPut]
        [Route]
        public async Task Put(BookedCar bookedCar)
        {
            await _repository.Update(bookedCar);
        }
        
        [HttpDelete]
        [Route]
        public async Task Delete(BookedCar bookedCar)
        {
            await _repository.Delete(bookedCar);
        }
    }
}