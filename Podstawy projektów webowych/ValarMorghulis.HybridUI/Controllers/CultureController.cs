using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValarMorghulis.Infrastructure.Services;

namespace ValarMorghulis.HybridUI.Controllers
{
    public class CultureController : Controller
    {
        private readonly CultureService cultureService = new CultureService();

        public JsonResult GetCultures(string q)
        {
            var result = cultureService.GetCultures();
            if (!String.IsNullOrEmpty(q))
            {
                result = result.Where(c => c.Name.ToLower().Contains(q.ToLower()));
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}