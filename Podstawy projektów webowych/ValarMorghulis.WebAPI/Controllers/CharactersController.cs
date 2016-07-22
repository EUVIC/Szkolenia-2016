using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ValarMorghulis.Common.Exceptions;
using ValarMorghulis.Common.Resources;
using ValarMorghulis.Infrastructure.Models;
using ValarMorghulis.Infrastructure.Services;

namespace ValarMorghulis.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CharactersController : ApiController
    {
        private readonly CharacterService service = new CharacterService();

        [HttpGet]
        public IHttpActionResult GetCharacters()
        {
            var result = service.GetCharacters();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetCharacterDetails(int id)
        {
            try
            {
                var result = service.GetCharacterDetails(id);
                return Ok(result);
            }
            catch (CharacterDoesNotExistException)
            {
                return BadRequest(Labels.CharacterDoesNotExistError);
            }
        }

        [HttpPost]
        public IHttpActionResult CreateCharacter([FromBody]CharacterDTO vm)
        {
            try
            {
                service.CreateCharacter(vm);
                return Ok();
            }
            catch (CharacterNameAlreadyTakenException)
            {
                return BadRequest(Labels.CharacterNameAlreadyTakenError);
            }
            catch (CharacterDoesNotExistException)
            {
                return BadRequest(Labels.CharacterDoesNotExistError);
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateCharacter(int id, [FromBody]CharacterDTO vm)
        {
            try
            {
                service.UpdateCharacter(id, vm);
                return Ok();
            }
            catch (CharacterNameAlreadyTakenException)
            {
                return BadRequest(Labels.CharacterNameAlreadyTakenError);
            }
            catch (CharacterDoesNotExistException)
            {
                return BadRequest(Labels.CharacterDoesNotExistError);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteCharacter(int id)
        {
            try
            {
                service.DeleteCharacter(id);
                return Ok();
            }
            catch (CharacterDoesNotExistException)
            {
                return BadRequest(Labels.CharacterDoesNotExistError);
            }
        }
    }
}
