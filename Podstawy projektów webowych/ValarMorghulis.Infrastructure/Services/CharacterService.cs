using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.Infrastructure.Services
{
	public class CharacterService
	{
		private readonly ICharacterRepository characterRepository;

		public CharacterService()
		{
			characterRepository = new CharacterRepository();
		}

		public CharacterDTO GetCharacterDetails(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			return Mapper.Map<CharacterDTO>(entity);
		}

		public IEnumerable<CharacterDTO> GetCharacters()
		{
			IQueryable<Character> entities = characterRepository.GetAll();
			return Mapper.Map<IEnumerable<CharacterDTO>>(entities);
		}

		public void CreateCharacter(CharacterDTO viewModel)
		{
			Character entity = Mapper.Map<Character>(viewModel);
			characterRepository.Add(entity);
			characterRepository.Save();
		}

        public void UpdateCharacter(int id, CharacterDTO viewModel)
        {
            Character entity = characterRepository.GetSingle(id);
            Mapper.Map(viewModel, entity);
            characterRepository.Save();
        }

        public void DeleteCharacter(int id)
        {
            Character entity = characterRepository.GetSingle(id);
            characterRepository.Delete(entity);
            characterRepository.Save();
        }
    }
}
