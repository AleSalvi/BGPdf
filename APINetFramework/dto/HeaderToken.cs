using System;

namespace dto { 
    public class HeaderToken
    {
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}