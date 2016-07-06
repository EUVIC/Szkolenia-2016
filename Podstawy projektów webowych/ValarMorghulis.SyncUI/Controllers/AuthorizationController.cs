using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValarMorghulis.Infrastructure.Models;
using ValarMorghulis.Infrastructure.Services;
using ValarMorghulis.SyncUI.Authorization;
using ValarMorghulis.SyncUI.ViewModels.Authorization;

namespace ValarMorghulis.SyncUI.Controllers
{
	public class AuthorizationController : Controller
	{
		private readonly CharacterService characterService = new CharacterService();


		[HttpGet]
		public ActionResult EnterTheHouse()
		{
			return View();
		}

		[HttpPost]
		public ActionResult EnterTheHouse(EnterTheHouseViewModel viewModel)
		{
			CharacterWithIdDTO allowedCharacter = characterService.GetCharacterAllowedToEnterHouse(viewModel.CharacterName, viewModel.HouseWords);
			if (allowedCharacter != null)
			{
				SessionManager.CurrentCharacter = allowedCharacter;
			}

			ModelState.AddModelError(string.Empty, "You are not allowed to enter the house.");
			return View();
		}
	}
}