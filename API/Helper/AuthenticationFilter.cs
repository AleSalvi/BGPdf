using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Helper
{
    public class AuthenticationFilter : AuthorizeAttribute, IAuthorizationFilter
    {
        public AuthenticationFilter()
        {
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Items["tk"] == null)
            {
                Guid? accountUid = SessionHelper.TokenHelper.GetAccountUidFromName(context.HttpContext.User.Identity.Name);

                if (accountUid != null)
                {
                    context.HttpContext.Items["tk"] = accountUid.Value.ToString();
                }
                else
                {
                    context.Result = new Microsoft.AspNetCore.Mvc.UnauthorizedResult();
                }
            }
        }
    }
}