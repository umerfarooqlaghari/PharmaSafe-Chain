using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels;
using ProjectLearn.Repository;

namespace ProjectLearn.Controllers.UsersControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _UserRepository;
        public UserController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type= typeof(IEnumerable<UserTable>))]
        public IActionResult GetUsers()
        {
            var users = _UserRepository.GetUsers();
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(users);
        }
    }
}
