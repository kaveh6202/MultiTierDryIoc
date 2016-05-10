using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DryIoc;
using DryIoc.Mvc;
using MultiTier.Common;

namespace MultiTier.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();
            container.Register<DryIocBootStarpper>(Reuse.Singleton);
            var bootStrapper = container.Resolve<DryIocBootStarpper>(IfUnresolved.ReturnDefault);
            bootStrapper.ConfigureContainer();
            container.WithMvc();
        }
    }
}
