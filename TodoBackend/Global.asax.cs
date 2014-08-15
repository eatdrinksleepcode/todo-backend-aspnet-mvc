using System.Web.Mvc;
using System.Web.Routing;


namespace TodoBackend
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;

	
	public class Global : System.Web.HttpApplication
	{
		
		protected void Application_Start(Object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		void RegisterRoutes(RouteCollection routes)
		{
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
		}
	}
}

