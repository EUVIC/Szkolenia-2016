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
            Infrastructure.AutoMapperConfiguration infrastructureConfig = new Infrastructure.AutoMapperConfiguration();
            infrastructureConfig.Configure();

            AutoMapperConfiguration localConfig = new AutoMapperConfiguration();
            localConfig.Configure();
        }
	}
}