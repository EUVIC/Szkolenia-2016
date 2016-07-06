using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValarMorghulis.HybridUI.Models;
using ValarMorghulis.Infrastructure.Models;
using ValarMorghulis.Infrastructure.Services;

namespace ValarMorghulis.HybridUI.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterService characterService = new CharacterService();

        // GET: Character
        public ActionResult Index()
        {
            return View();
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
            return View(viewModel);
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(CreateCharacterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                characterService.CreateCharacter(AutoMapperConfiguration.characterMapper.Map<CharacterDTO>(viewModel));
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Form data is invalid.");
            return View();
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = AutoMapperConfiguration.characterMapper.Map<UpdateCharacterViewModel>(characterService.GetCharacterDetails(id));
                    return View("Edit", result);
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UpdateCharacterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update logic here
                characterService.UpdateCharacter(id, AutoMapperConfiguration.characterMapper.Map<CharacterDTO>(viewModel));
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", viewModel);
            }
        }

        // POST: Character/Delete/5
        [HttpPost]
        public void Delete(int id)
        {
            characterService.DeleteCharacter(id);
        }

        public JsonResult GetCharacters()
        {
            var result = AutoMapperConfiguration.characterMapper.Map<IEnumerable<CharacterListElementViewModel>>(characterService.GetCharacters());
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
