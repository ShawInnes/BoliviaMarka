using System.Web.Mvc;

namespace Website
{
	public static class FilterConfig
	{
		public static void Register(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());	
		}
	}
}