using CarShop.Api.Attributes;
using CarShop.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Cars
{
    public class CarCreateDto
    {
        [Required(ErrorMessage = "Please fill out valid name")]
        [MaxLength(30)]
        [MinLength(2)]
        public string Name { get; set; } = string.Empty;
        public int Version { get; set; }
        public string Company { get; set; } = string.Empty;
        //[Required(ErrorMessage ="Please fill out valid colr")]
        [ValidColor(ErrorMessage = "This color is not supported")]
        public string Color { get; set; } = string.Empty;
        [Required()]
        public double Price { get; set; }
        public DateTime ProductionAt { get; set; }
        public static implicit operator Car(CarCreateDto dto)
        {
            return new Car()
            {
                Name = dto.Name,
                Color = dto.Color,
                Company = dto.Company,
                Price = dto.Price,
                ProductionAt = dto.ProductionAt,
                Version = dto.Version
            };
        }
    }
}
