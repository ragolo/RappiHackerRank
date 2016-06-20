namespace Rappi.HackerRank.Web
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Castle.Core;
    using Core.IoC;
    using CubeSummation.Installer;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = IocHelper.GetInstance();
            container.Install(new WindsorInstaller(container, LifestyleType.PerWebRequest, new ProcessSettingsFactory().CreateProcessSettings()));
        }
    }
}
