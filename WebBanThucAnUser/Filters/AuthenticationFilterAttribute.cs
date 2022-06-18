using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

public class AuthenticationFilterAttribute : AuthorizeAttribute
{
    //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
    //{
    //    if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
    //    {
    //        filterContext.Result = new HttpUnauthorizedResult();
    //    }
    //    else
    //    {
    //        filterContext.Result = new RedirectToRouteResult(new
    //            RouteValueDictionary(new { controller = "AccessDenied" }));
    //    }
    //}
}


