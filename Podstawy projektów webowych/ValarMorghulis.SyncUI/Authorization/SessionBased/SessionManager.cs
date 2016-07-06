using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.SyncUI.Authorization
{
	public static class SessionManager
	{
		public static void Clear()
		{
			HttpContext.Current.Session.Clear();
			HttpContext.Current.Session.Abandon();
		}

		public static bool IsCharacterLoggedIn
		{
			get { return HttpContext.Current.Session["currentcharacter"] != null; }
		}

		public static CharacterWithIdDTO CurrentCharacter
		{
			get
			{
				return HttpContext.Current.Session["currentcharacter"] as CharacterWithIdDTO;
			}
			set
			{
				HttpContext.Current.Session["currentuser"] = value;
				if (value != null)
				{
					CurrentCharacterId = value.Id;
				}
			}
		}

		public static long? CurrentCharacterId
		{
			get
			{
				return (long?)HttpContext.Current.Session["characterid"];
			}
			set
			{
				HttpContext.Current.Session["characterid"] = value;
			}
		}
	}
}