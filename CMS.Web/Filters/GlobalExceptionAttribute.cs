using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.Filters
{
    public class GlobalExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            //TODO...
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
            {
                //是否是Ajax请求
            }
            filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { controller = "Home", action = "Error" }));
            //base.OnException(filterContext);
        }
    }
}