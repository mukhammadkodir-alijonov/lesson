using CarShop.Api.Dtos.Accounts;
using CarShop.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accounService;

        public AccountsController(IAccountService accountService)
        {
            this._accounService = accountService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] AccountRegisterDto dto)
        {
            return Ok(await _accounService.RegisterAsync(dto));
        }
    }
}
