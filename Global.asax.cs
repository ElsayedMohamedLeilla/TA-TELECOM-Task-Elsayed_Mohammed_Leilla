using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Elsayed_Mohammed_Leilla
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //     Database.SetInitializer<ApplicationDbContext>(
            //new MigrateDatabaseToLatestVersion<ApplicationDbContext, Elsayed_Mohammed_Leilla.Migrations.Configuration>());
            //     var dbMigrator = new DbMigrator(new Elsayed_Mohammed_Leilla.Migrations.Configuration());
            //     dbMigrator.Update();

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Elsayed_Mohammed_Leilla.Migrations.Configuration>());
            //using (var temp = new ApplicationDbContext())
            //{
            //    temp.Database.Initialize(true);
            //}
        }
    }
}
