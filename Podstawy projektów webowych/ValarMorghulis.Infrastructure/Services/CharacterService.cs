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
		private readonly ICultureRepository cultureRepository;

		public CharacterService()
		{
			characterRepository = new CharacterRepository();
		}

		public CharacterDTO GetCharacterDetails(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			return AutoMapperConfiguration.characterMapper.Map<CharacterDTO>(entity);
		}

		public IEnumerable<CharacterListElementDTO> GetCharacters()
		{
			IQueryable<Character> entities = characterRepository.GetAll();
			return AutoMapperConfiguration.characterMapper.Map<IEnumerable<CharacterListElementDTO>>(entities);
		}

		public void CreateCharacter(CharacterDTO viewModel)
		{
			Character entity = AutoMapperConfiguration.characterMapper.Map<Character>(viewModel);
			characterRepository.Add(entity);
			characterRepository.Save();
		}

        public void UpdateCharacter(int id, CharacterDTO viewModel)
        {
            Character entity = characterRepository.GetSingle(id);
            AutoMapperConfiguration.characterMapper.Map(viewModel, entity);
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
