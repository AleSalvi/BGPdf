using API.Provider;
using dto;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace APINetFramework.Helper
{
    public class UserController : ApiController
    {

        [TokenAuthenticationFilter]
        [HttpGet]
        [Route("api/user/getall")]
        public List<User> getAll()
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.GetUsers();
        }

        [TokenAuthenticationFilter]
        [HttpGet]
        [Route("api/user/getbyuid")]
        public User getByUid(Guid Uid)
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.GetUserByUid(Uid);
        }

        [TokenAuthenticationFilter]
        [HttpPost]
        [Route("api/user/edit")]
        public User edit([FromBody] User user)
        {
            userProvider _userMethods = new userProvider();

            return _userMethods.EditUser(user);
        }

    }
}