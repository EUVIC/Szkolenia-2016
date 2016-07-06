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
            IEnumerable<CharacterListElementViewModel> modelCollection = AutoMapperConfiguration.characterMapper.Map<IEnumerable<CharacterListElementViewModel>>(characterService.GetCharacters());
            return View(modelCollection);
        }

        // GET: Character/Details/5
        public ActionResult Details(int id)
        {
            CharacterDetailsViewModel model = AutoMapperConfiguration.characterMapper.Map<CharacterDetailsViewModel>(characterService.GetCharacterDetails(id));
            return View(model);
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            var viewModel = new CreateCharacterViewModel();
            viewModel.CultureOptions = AutoMapperConfiguration.characterMapper.Map<IEnumerable<CultureSelectListItemViewModel>>(cultureService.GetCultures());
            return View(viewModel);
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(CreateCharacterViewModel viewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    characterService.CreateCharacter(AutoMapperConfiguration.characterMapper.Map<CharacterDTO>(viewModel));
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

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
