﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Industry.Front.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //TODO Используем OWIN смотри Startup
            //System.Data.Entity.Database.SetInitializer(new ERPModelInitializer());
            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register); 
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
