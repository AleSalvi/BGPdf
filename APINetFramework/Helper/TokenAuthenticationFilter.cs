using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace APINetFramework.Helper
{
    public class TokenAuthenticationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Method.Method == "OPTIONS")
                return;
            string headerToken = string.Empty;
            IEnumerable<string> values;

            if (actionContext.Request.Headers.TryGetValues("X-AUTH", out values))
                headerToken = values.FirstOrDefault();

            var ErrorToken = true;

            if (!string.IsNullOrWhiteSpace(headerToken))
            {
                int durationMinutes = 24 * 60;

                Guid? accountUid = TokenHelper.GetUserFromToken(headerToken, durationMinutes);

                if (accountUid != null)
                {
                    ErrorToken = false;
                    SessionHelper.Get().AccountUid = accountUid.Value;
                }
                else
                    ErrorToken = true;
            }
            else
                ErrorToken = true;

            if (ErrorToken)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                actionContext.Response.Content = new StringContent("{\"statusCode\":\"401\", \"errorDesc\":\"Invalid Token\", \"payload\":\"\"}");
            }
        }
    }
}