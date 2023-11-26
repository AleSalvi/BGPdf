﻿using APINetFramework.Helper;
using dto;
using System;
using System.Web.Http;

namespace APINetFramework.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/login/authenticate")]
        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse result;

            try
            {
                if (request.Username == "BGCacciaPescaAdministrator" && request.Password == "00CacciaEPesca00")
                {
                    TokenHelper tk = TokenHelper.GetNewToken(Guid.NewGuid());

                    result = new LoginResponse()
                    {
                        ErrorMessage = string.Empty,
                        Success = true,
                        Token = tk.Token
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