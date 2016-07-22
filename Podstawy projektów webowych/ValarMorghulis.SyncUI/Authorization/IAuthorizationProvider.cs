using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.SyncUI.Authorization
{
	public interface IAuthorizationProvider
	{
		bool IsCharacterAuthenticated { get; }

		long CharacterId { get; }

		void LogOut();
	}
}
