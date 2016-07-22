using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValarMorghulis.SyncUI.Authorization.SessionBased;

namespace ValarMorghulis.SyncUI.Authorization
{
	public static class AuthorizationManager
	{
		private const string AuthProviderKey = "AuthProvider";
		private static IAuthorizationProvider _authProvider
		{
			get { return HttpContext.Current.Items[AuthProviderKey] as IAuthorizationProvider; }
			set { HttpContext.Current.Items[AuthProviderKey] = value; }
		}

		public static IAuthorizationProvider AuthProvider
		{
			get
			{
				if (_authProvider == null)
				{
					var authValue = HttpContext.Current.Request.Headers["Authorization"];
					if (string.IsNullOrEmpty(authValue))
						_authProvider = new SessionBasedAuthenticationProvider();   //logowanie sesją
				}
				return _authProvider;
			}
		}

		public static bool IsCharacterAuthenticated
		{
			get
			{
				return AuthProvider.IsCharacterAuthenticated;
			}
		}

		public static long CharacterId
		{
			get
			{
				return AuthProvider.CharacterId;
			}
		}

		public static void LogOut()
		{
			AuthProvider.LogOut();
		}
	}
}