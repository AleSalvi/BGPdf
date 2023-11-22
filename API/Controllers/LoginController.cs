using API.Helper;
using dto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public LoginController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("authenticate")]
        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse result;

            try
            {
                if (request.Username == "BGCacciaPescaAdministrator" && request.Password == "00CacciaEPesca00")
                {
                    String tk = SessionHelper.TokenHelper.GetNewToken(Guid.NewGuid()).Token;

                    result = new LoginResponse()
                    {
                        ErrorMessage = string.Empty,
                        Success = true,
                        Token = tk
                    };
                }
                else
                {

                    result = new LoginResponse()
                    {
                        ErrorMessage = "Username o password non corrette. Autenticazione fallita!",
                        Success = false,
                        Token = string.Empty
                    };
                }

            }
            catch (Exception ex)
            {
                result = new LoginResponse()
                {
                    ErrorMessage = ex.ToString(),
                    Success = false,
                    Token = string.Empty
                };
            }

            return result;
        }
    }
}
