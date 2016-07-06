using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.Interfaces;
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

		public CharacterWithIdDTO GetCharacterDetails(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			return Mapper.Map<CharacterWithIdDTO>(entity);
		}

		public IEnumerable<CharacterWithIdDTO> GetCharacters()
		{
			IQueryable<Character> entities = characterRepository.GetAll();
			return Mapper.Map<IEnumerable<CharacterWithIdDTO>>(entities);
		}

		public void CreateCharacter(CharacterDTO viewModel)
		{
			Character entity = Mapper.Map<Character>(viewModel);
			characterRepository.Add(entity);
			characterRepository.Save();
		}

		public void UpdateCharacter(int id, ICharacterDTO viewModel)
		{
			Character entity = characterRepository.GetSingle(id);
			Mapper.Map(viewModel, entity);
			characterRepository.Save();
		}

		public void UpdateCharacter(CharacterWithIdDTO viewModel)
		{
			UpdateCharacter(viewModel.Id, viewModel);
		}

		public void DeleteCharacter(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			characterRepository.Delete(entity);
			characterRepository.Save();
		}
	}
}
