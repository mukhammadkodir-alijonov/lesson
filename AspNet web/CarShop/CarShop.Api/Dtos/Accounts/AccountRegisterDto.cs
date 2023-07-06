using CarShop.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Accounts
{
    public class AccountRegisterDto
    {
        [Required, MaxLength(30), MinLength(2)]
        public string FirstName { get; set; } = string.Empty;
        [Required, MaxLength(30), MinLength(2)]
        public string LastName { get; set; } = string.Empty;
        [Required, MaxLength(30), MinLength(2), EmailAddress]
        public string Email { get; set; } = string.Empty;
        public IFormFile? Image { get; set; }
        [Required, MinLength(8)]
        public string Password { get; set; } = string.Empty;
        public static implicit operator User(AccountRegisterDto dto)
        {
            return new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName
            };
        }
    }
}
