using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;

namespace Watcher
{
    public class MvcApplication : System.Web.HttpApplication
    {
        FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
        protected void Application_Start()
        {
            Program program = new Program();
            fileSystemWatcher.Path = @"E:\\";
            fileSystemWatcher.Created+= new FileSystemEventHandler(program.FileChanged);

            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName;
            fileSystemWatcher.Filter = "*.csv";
            fileSystemWatcher.EnableRaisingEvents = true;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
