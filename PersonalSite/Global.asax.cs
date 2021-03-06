﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using PersonalSite.Controllers;

namespace PersonalSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_EndRequest()
        {
            if (Context.Response.StatusCode != 200)
            {
                var myRoute = new RouteData();
                myRoute.DataTokens["area"] = "AreaName";
                myRoute.Values["controller"] = "Error";
                myRoute.Values["action"] = "NotFound";

                IController controller = new ErrorController(Context.Response.StatusCode.ToString());
                Response.Clear();
                controller.Execute(new RequestContext(new HttpContextWrapper(Context), myRoute));
            }
        }

    }
}
