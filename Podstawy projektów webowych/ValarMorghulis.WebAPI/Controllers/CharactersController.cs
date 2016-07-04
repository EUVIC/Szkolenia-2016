using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ValarMorghulis.Infrastructure.Services;
using ValarMorghulis.Infrastructure.ViewModels.Character;

namespace ValarMorghulis.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CharactersController : ApiController
    {
        private readonly CharacterService service = new CharacterService();

        public IHttpActionResult GetCharacters()
        {
            var result = service.GetCharacters();
            return Ok(result);
        }

        public IHttpActionResult GetCharacterDetails(int id)
        {
            var result = service.GetCharacterDetails(id);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult CreateCharacter([FromBody]CreateCharacterViewModel vm)
        {
            service.CreateCharacter(vm);
            return Ok();
        }
    }
}
