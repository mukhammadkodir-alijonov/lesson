using CarShop.Api.DbContexts;
using CarShop.Api.Dtos.Accounts;
using CarShop.Api.Interfaces;
using CarShop.Api.Models;
using CarShop.Api.Security;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _repository;
        private readonly IFileService _fileService;

        public AccountService(AppDbContext appDbContext, IFileService fileService)
        {
            this._repository = appDbContext;
            this._fileService = fileService;
        }
        public async Task<bool> RegisterAsync(AccountRegisterDto dto)
        {
            var emailUser = await _repository.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (emailUser is not null) throw new Exception("Email is already existed");
            var hasherResult = PaswordHasher.Hash(dto.Password);
            var userEntity = (User)dto;
            userEntity.PasswordHash = hasherResult.PasswordHash;
            userEntity.Salt = hasherResult.Salt;

            if (dto.Image is not null)
            {
                userEntity.ImagePath = await _fileService.SaveImageAsync(dto.Image);
            }
            _repository.Users.Add(userEntity);
            var dbReult = await _repository.SaveChangesAsync();
            return dbReult > 0;
        }
    }
}
