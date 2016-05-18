using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebReserva
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError().GetBaseException();
            Server.ClearError();
            var routeData = new RouteData();
            routeData.Values.Add("controller", "Erro");
            routeData.Values.Add("action", "Status");

            if (exception.GetType() == typeof(HttpException))
            {
                var httpException = (HttpException)exception;
                var code = httpException.GetHttpCode();
                routeData.Values.Add("status", code);
            }
            else
            {
                if (exception.Message == "EXCEPTION_TENANT_NOT_FOUND")
                {
                    routeData.Values.Add("status", 404);
                }
                else
                {
                    routeData.Values.Add("status", 500);
                }
            }

            routeData.Values.Add("error", exception);
            IController errorController = new Controllers.Web.ErroController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        }
    }
}
