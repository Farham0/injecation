using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Filters
{
	public class CustomActionFilter:ActionFilterAttribute, IActionFilter

	{

		void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {

            string ip = filterContext.HttpContext.Request.UserHostAddress.ToString();

            string controllername = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            OnActionExecuting(filterContext);
        }

		void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            string ip = filterContext.HttpContext.CurrentHandler.ToString();
            OnActionExecuted(filterContext);
        }
	}
}