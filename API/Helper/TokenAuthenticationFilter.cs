using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;

namespace API.Helper
{
    public class TokenAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Escludo controllo per chiamata OPTIONS
            if (context.HttpContext.Request.Method == "OPTIONS") return;
            //Controllo se attivo Secure DB

            if (SessionHelper.TokenHelper.IsWindowsAuth)
                return;

            string headerToken = string.Empty;

            StringValues values;

            if (context.HttpContext.Request.Headers.TryGetValue("X-AUTH", out values))
            {
                headerToken = values.FirstOrDefault();
            }

            bool ErrorToken = true;
            if (!string.IsNullOrWhiteSpace(headerToken))
            {
                int durationMinutes = 24 * 60;

                Guid? accountUid = SessionHelper.TokenHelper.GetAccountUidFromToken(headerToken, durationMinutes);

                if (accountUid != null)
                {
                    ErrorToken = false;

                    context.HttpContext.Items["tk"] = accountUid.Value.ToString();
                }
                else
                    ErrorToken = true;
            }
            else
            {
                ErrorToken = true;
            }


            if (ErrorToken)
            {
                context.Result = new Microsoft.AspNetCore.Mvc.UnauthorizedResult();
            }
        }
    }
}