using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AuthDemo
{
    public class Startup
    {
        //install-package microsoft.Owin  
        public void Configuration(IAppBuilder app)
        {
            //inside Sytem.Web.Mvc
            RouteTable.Routes.MapRoute("default", "{controller}/{action}/{id}", new { controller = "Home" , action = "Index",id = "0"});


        }
    }
}