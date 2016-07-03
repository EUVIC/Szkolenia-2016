using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValarMorghulis.Infrastructure;

namespace ValarMorghulis.SyncUI.App_Start
{
	public class AutoMapperConfig
	{
		/// <summary>
		/// Automapper registration.
		/// </summary>
		public static void RegisterAutoMapper()
		{
			AutoMapperConfiguration config = new AutoMapperConfiguration();
			config.Configure();
		}
	}
}