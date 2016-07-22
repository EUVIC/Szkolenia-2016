using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValarMorghulis.Infrastructure.Models;
using ValarMorghulis.Infrastructure.Services;
using ValarMorghulis.SyncUI.ViewModels.Character;
using ValarMorghulis.SyncUI.ViewModels.Culture;

namespace ValarMorghulis.SyncUI.Controllers
{
	public class CharacterController : Controller
	{
		private readonly CharacterService characterService = new CharacterService();
		private readonly CultureService cultureService = new CultureService();

		// GET: Character
		public ActionResult Index()
		{
			IEnumerable<CharacterListElementViewModel> modelCollection = Mapper.Map<IEnumerable<CharacterListElementViewModel>>(characterService.GetCharacters());
			return View(modelCollection);
		}

		// GET: Character/Details/5
		public ActionResult Details(int id)
		{
			CharacterDetailsViewModel model = Mapper.Map<CharacterDetailsViewModel>(characterService.GetCharacterDetails(id));
			return View(model);
		}

		// GET: Character/Create
		public ActionResult Create()
		{
			var viewModel = new CreateCharacterViewModel();
			viewModel.CultureOptions = Mapper.Map<IEnumerable<CultureSelectListItemViewModel>>(cultureService.GetCultures());
			return View(viewModel);
		}

		// POST: Character/Create
		[HttpPost]
		public ActionResult Create(CreateCharacterViewModel viewModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					characterService.CreateCharacter(Mapper.Map<CharacterDTO>(viewModel));
					return RedirectToAction("Index");
				}
				ModelState.AddModelError(string.Empty, "Form data is invalid.");
				return View();
			}
			catch
			{
				return View();
			}
		}

		public ActionResult Edit(int id)
		{
			UpdateCharacterViewModel viewModel = Mapper.Map<UpdateCharacterViewModel>(characterService.GetCharacterDetails(id));
			viewModel.CultureOptions = Mapper.Map<IEnumerable<CultureSelectListItemViewModel>>(cultureService.GetCultures());
			return View(viewModel);
		}

		[HttpPost]
		public ActionResult Edit(UpdateCharacterViewModel viewModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					characterService.UpdateCharacter(Mapper.Map<CharacterWithIdDTO>(viewModel));
					return RedirectToAction("Index");
				}
				ModelState.AddModelError(string.Empty, "Form data is invalid.");
				return View();
			}
			catch
			{
				return View();
			}
		}

		// POST: Character/Delete/5
		[HttpGet]
		public ActionResult Delete(int id)
		{
			try
			{
				characterService.DeleteCharacter(id);
				return RedirectToAction("Index");
			}
			catch
			{
				// TODO; Go to error page
				return RedirectToAction("Index");
			}
		}
	}
}
