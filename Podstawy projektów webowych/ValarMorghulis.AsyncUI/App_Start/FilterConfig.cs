using System.Web;
using System.Web.Mvc;

namespace ValarMorghulis.AsyncUI
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
