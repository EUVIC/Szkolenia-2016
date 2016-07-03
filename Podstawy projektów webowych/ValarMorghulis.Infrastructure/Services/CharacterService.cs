using System;
using System.Collections.Generic;
using System.Linq;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.ViewModels.Character;

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

		public CharacterDetailsViewModel GetCharacterDetails(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			return AutoMapperConfiguration.characterMapper.Map<CharacterDetailsViewModel>(entity);
		}

		public IEnumerable<CharacterListElementViewModel> GetCharacters()
		{
			IQueryable<Character> entities = characterRepository.GetAll();
			return AutoMapperConfiguration.characterMapper.Map<IEnumerable<CharacterListElementViewModel>>(entities);
		}

		public void CreateCharacter(CreateCharacterViewModel viewModel)
		{
			Character entity = AutoMapperConfiguration.characterMapper.Map<Character>(viewModel);
			characterRepository.Add(entity);
			characterRepository.Save();
		}
	}
}
