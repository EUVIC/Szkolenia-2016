using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ValarMorghulis.Infrastructure.Services;

namespace ValarMorghulis.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CulturesController : ApiController
    {
        private readonly CultureService service = new CultureService();

        public IHttpActionResult GetCultures()
        {
            var result = service.GetCultures();
            return Ok(result);
        }
    }
}
