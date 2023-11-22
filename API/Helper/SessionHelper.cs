namespace API.Helper
{
    public class SessionHelper
    {
        public static Guid GetAccountUid(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext.Items["tk"] != null)
                return new Guid(httpContextAccessor.HttpContext.Items["tk"].ToString());
            else
                return Guid.Empty;
        }

        public static string GetNewToken(IHttpContextAccessor httpContextAccessor)
        {
            return TokenHelper.GetNewToken(SessionHelper.GetAccountUid(httpContextAccessor)).Token;
        }
        public static TokenHelper TokenHelper { get; set; }

    }
}