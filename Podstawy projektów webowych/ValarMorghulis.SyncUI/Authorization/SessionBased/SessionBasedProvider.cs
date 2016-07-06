using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValarMorghulis.SyncUI.Authorization.SessionBased
{
	public class SessionBasedAuthenticationProvider : IAuthorizationProvider
	{
		/// <summary>
		/// Gets a value indicating whether this instance is user authenticated.
		/// </summary>
		bool IAuthorizationProvider.IsCharacterAuthenticated
		{
			get { return SessionManager.IsCharacterLoggedIn; }
		}

		/// <summary>
		/// Gets the user identifier.
		/// </summary>
		public long CharacterId
		{
			get { return SessionManager.CurrentCharacterId.Value; }
		}

		/// <summary>
		/// Logs the out.
		/// </summary>
		public void LogOut()
		{
			SessionManager.Clear();
		}
	}
}