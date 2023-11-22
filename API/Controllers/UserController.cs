using API.Helper;
using API.Provider;
using dto;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        //[TokenAuthenticationFilter]
        [HttpGet]
        [Route("getall")]
        public List<User> getAll()
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.GetUsers();
        }

        //[TokenAuthenticationFilter]
        [HttpGet]
        [Route("getbyuid")]
        public User getByUid(Guid Uid)
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.GetUserByUid(Uid);
        }

        //[TokenAuthenticationFilter]
        [HttpPost]
        [Route("edit")]
        public User edit([FromBody] User user)
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.EditUser(user);
        }

    }
}