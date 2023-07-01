using asp_net_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<User> listUser = new List<User>()
        {
            new User
            {
                Id = 1,
                FirstName = "Alijonov",
                LastName = "Muhammad"
            },
            new User
            {
                Id = 2,
                FirstName = "Hamidov",
                LastName = "Qutbiddin"

            },
            new User
            {
                Id = 3,
                FirstName = "Alimov",
                LastName = "Vali"
            },
            new User
            {
                Id = 4,
                FirstName = "Xurramov",
                LastName = "Qahhor"
            },
            new User
            {
                Id = 5,
                FirstName = "Malikov",
                LastName = "Sardor"
            }
        };
        [HttpGet]
        public List<User> GetUsers()
        {
            return listUser;
        }
        [HttpGet("id")]
        public User GetId(int id)
        {
            return listUser.FirstOrDefault(x => x.Id == id);
        }
    }
}
