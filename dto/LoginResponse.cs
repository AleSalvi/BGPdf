﻿namespace dto
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }

}