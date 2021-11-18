using AutoMapper;
using CarInformationTask.DAL;
using CarInformationTask.Entities.DTO;
using CarInformationTask.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarContext _carContext;
        private readonly IMapper _mapper;

        public CarController(CarContext carContext, IMapper mapper)
        {
            _carContext = carContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            IEnumerable<CarForGetDTO> carDTOs = _mapper.Map<IEnumerable<CarForGetDTO>>(await _carContext.Cars.Include(c => c.CarType).ToListAsync());
            return Ok(carDTOs);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<Car, CarForGetDTO>(await _carContext.Cars.Include(c => c.CarType).FirstOrDefaultAsync(c => c.CarId == id)));
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody] CarDTO carDTO)
        {
            Car newcar = _mapper.Map<Car>(carDTO);

            await _carContext.Cars.AddAsync(newcar);
            await _carContext.SaveChangesAsync();
            return Ok(carDTO);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] CarDTO carDTO)
        {
            Car car = await _carContext.Cars.FirstOrDefaultAsync(c => c.CarId == id);

            _mapper.Map<CarDTO, Car>(carDTO, car);
            await _carContext.SaveChangesAsync();
            return Ok(carDTO);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var car = await _carContext.Cars.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            _carContext.Cars.Remove(car);
            await _carContext.SaveChangesAsync();
            return Ok();
        }
    }
}
