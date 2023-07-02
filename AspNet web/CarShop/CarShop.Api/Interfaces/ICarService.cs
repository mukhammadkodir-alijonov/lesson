using CarShop.Api.Models;

namespace CarShop.Api.Interfaces
{
    public interface ICarService
    {
        public Task<IEnumerable<Car>> GetAllAsync();
        public Task<Car> GetAsync(long id);
        public Task<bool> DeleteAsync(long id);
        public Task<bool> CreateAsync(Car obj);
        public Task<bool> UpdateAsync(Car obj,long id);
    }
}
