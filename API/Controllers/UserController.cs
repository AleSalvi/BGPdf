using API.Helper;
using API.Provider;
using dto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private userProvider _userMethods;

        public UserController(ILogger<UserController> logger, userProvider userMethods)
        {
            _logger = logger;
            _userMethods = userMethods;
        }

        [TokenAuthenticationFilter]
        [HttpGet(Name = "getall")]
        public List<User> getAll()
        {
            return _userMethods.GetUsers();
        }

        [TokenAuthenticationFilter]
        [HttpGet(Name = "getbyuid")]
        public User getByUid(Guid Uid)
        {
            return _userMethods.GetUserByUid(Uid);
        }

        [TokenAuthenticationFilter]
        [HttpPost(Name = "edit")]
        public User edit(User user)
        {
            return _userMethods.EditUser(user);
        }

    }
}