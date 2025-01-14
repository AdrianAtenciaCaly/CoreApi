using CoreApi.Models;
using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
       [ApiController]
        [Route("[controller]")]
        public class UserController : ControllerBase
        {
            private readonly UserService _userService;

            public UserController(UserService userService)
            {
                _userService = userService;
            }
        [HttpGet(Name = "GetUsers")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            if (users == null || users.Count == 0)
            {
                return NotFound();
            }

            return Ok(users);
        }
    }
    
}
