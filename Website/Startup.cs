using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Website.Startup))]

namespace Website
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

			AreaRegistration.RegisterAllAreas();

			FilterConfig.Register(GlobalFilters.Filters);
			RouteConfig.Register(RouteTable.Routes);
			BundleConfig.Register(BundleTable.Bundles);
		}
	}
}
