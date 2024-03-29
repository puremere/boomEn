﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace banimo.Classes 
{
    public class SessionCheck : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            var descriptor = filterContext.ActionDescriptor;
            var actionName = descriptor.ActionName;

            if (actionName != "Index" && actionName != "CustomerLogin" && actionName != "createUserReport")
            {
                HttpSessionStateBase session = filterContext.HttpContext.Session;
                
                string val = session["LogedInUser2"] == null ? "" : session["LogedInUser2"] as string;
                if (session["LogedInUser2"] == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary {
                                { "Controller", "Admin" },
                                { "Action", "Index" }
                                    });
                }
                else
                {
                    if (session["partner"] as string != "0")
                    {
                        if (actionName != "Edit" && actionName != "product" && actionName != "resetAdminProductPage" && actionName != "GetTheListOfItems" && actionName != "CustomerLogout")
                        {
                            filterContext.Result = new RedirectToRouteResult(
                      new RouteValueDictionary {
                                { "Controller", "Admin" },
                                { "Action", "product" }
                                  });
                        }
                    }
                }
            }
           
        }
    }

    public class HomeSessionCheck : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpSessionStateBase session = filterContext.HttpContext.Session;
            if (session["lang"] == null)
            {
                session["lang"] = "en";
            }
            if (session["serverName"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                                { "Controller", "Home" },
                                { "Action", "zero" }
                                });
            }

        }
    }

    public class doForAll : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpSessionStateBase session = filterContext.HttpContext.Session;
            if (session["LogedInUser"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                                { "Controller", "Home" },
                                { "Action", "login" }
                                });
            }

        }
    }
}