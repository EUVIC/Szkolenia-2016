using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValarMorghulis.SyncUI.ViewModels.Authorization
{
	public class EnterTheHouseViewModel
	{
		[Required]
		public string CharacterName { get; set; }

		public string HouseWords { get; set; }
	}
}