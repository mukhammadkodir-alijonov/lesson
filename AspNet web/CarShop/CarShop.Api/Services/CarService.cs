using CarShop.Api.DbContexts;
using CarShop.Api.Dtos.Cars;
using CarShop.Api.Exceptions;
using CarShop.Api.Interfaces;
using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext appDbContext;
        public CarService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await appDbContext.Cars.AsNoTracking()
                  .ToListAsync();
        }
        public async Task<Car> GetAsync(long id)
        {
            var result = await appDbContext.Cars.FindAsync(id);
<<<<<<< HEAD
            if (result is not null) throw new NotFoundException("Car Not Found");
            else return result!;
=======
            if (result is not null) throw new NotFoundException("Car not found!");
            else return result;
>>>>>>> 080b7c750e398845db77e2352ecad5a54db77317
        }
        public async Task<bool> CreateAsync(CarCreateDto dto)
        {
            var entity = (Car)dto;
            appDbContext.Cars.Add(dto);
            var result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await appDbContext.Cars.FindAsync(id);
            if (entity is not null)
            {
                appDbContext.Cars.Remove(entity);
                var result = await appDbContext.SaveChangesAsync();
                return (result > 0);
            }
            else throw new NotFoundException("Car not found");
        }
        public async Task<bool> UpdateAsync(Car obj, long id)
        {
            var entity = await appDbContext.Cars.FindAsync(id);
            appDbContext.Entry<Car>(entity!).State = EntityState.Detached;
            if (entity is not null)
            {
                obj.Id = id;
                appDbContext.Cars.Update(obj);
                var result = await appDbContext.SaveChangesAsync();
                return (result > 0);
            }
            else throw new NotFoundException("Car not found");
        }
    }
}
