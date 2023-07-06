using CarShop.Api.Dtos.Cars;
using CarShop.Api.Exceptions;
using CarShop.Api.Interfaces;
using CarShop.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsContorller : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsContorller(ICarService carService)
        {
            this._carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _carService.GetAllAsync();
                return Ok(result);
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            try
            {
                var result = await _carService.GetAsync(id);
                return Ok(result);
            }
            catch (NotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] CarCreateDto dto)
        {
            try
            {
                var result = await _carService.CreateAsync(dto);
                if (result) return Ok();
                else return BadRequest();
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(long id)
        {
            try
            {
                var result = await _carService.DeleteAsync(id);
                return Ok(result);
            }
            catch (NotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateByIdAsync(long id, [FromBody] Car obj)
        {
            try
            {
                var result = await _carService.UpdateAsync(obj, id);
                return Ok(result);
            }
            catch (NotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
