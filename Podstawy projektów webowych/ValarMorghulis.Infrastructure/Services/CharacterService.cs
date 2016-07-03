using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.ViewModels.Character;

namespace ValarMorghulis.Infrastructure.Services
{
	public class CharacterService
	{
		private readonly ICharacterRepository characterRepository;

		public CharacterService()
		{
			characterRepository = new CharacterRepository();
		}

		public CharacterDetailsViewModel GetCharacterDetails(int id)
		{
			Character entity = characterRepository.GetSingle(id);
			return AutoMapperConfiguration.characterMapper.Map<CharacterDetailsViewModel>(entity);
		}
	}
}
