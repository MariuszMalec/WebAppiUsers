using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nest;
using WebAppiUsers.Models;
using WebAppiUsers.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppiUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryService<User> _userService;

        public UserController(IRepositoryService<User> userService)
        {
            _userService = userService;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAll();
            if (!users.Any())
                return BadRequest($"Brak uzytkowników!");
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Brak uzytkownika!");
            await _userService.Insert(user);
            //return Ok($"User with id {user.Id} added");
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
                return BadRequest($"Brak uzytkownika!");
            return Ok(user);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] User user)
        {
            if (user == null)
                return BadRequest($"Brak uzytkownika!");
            _userService.Update(user);
            return Ok($"User with id {user.Id} edited");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
                return BadRequest($"Brak uzytkownika!");
            _userService.Delete(id);
            return Ok($"User with id {id} deleted");
        }
    }
}
