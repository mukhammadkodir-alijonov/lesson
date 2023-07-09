using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Orders;
using CarShop.Api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] OrderCreateDto orderCreateDto)
            => Ok(await _orderService.CreateAsync(orderCreateDto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _orderService.GetAllAsync(@params));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(await _orderService.GetByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, [FromForm] OrderCreateDto orderCreateDto)
            => Ok(await _orderService.UpdateAsync(id, orderCreateDto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _orderService.DeleteAsync(id));
    }
}
