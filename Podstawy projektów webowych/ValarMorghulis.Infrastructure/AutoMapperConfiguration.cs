using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Infrastructure.ViewModels.Character;
using ValarMorghulis.Infrastructure.ViewModels.Culture;

namespace ValarMorghulis.Infrastructure
{
	public class AutoMapperConfiguration
	{
		public static IMapper characterMapper;
		public static IMapper houseMapper;

		public void Configure()
		{
			var characterConfig = new MapperConfiguration(cfg =>
			{
				// Entity to VM
				// Character
				cfg.CreateMap<Character, CharacterDetailsViewModel>();
				cfg.CreateMap<Character, CharacterListElementViewModel>();

				// Culture
				cfg.CreateMap<Culture, CultureSelectListItemViewModel>();

				// VM to Entity
				// Character
				cfg.CreateMap<CreateCharacterViewModel, Character>();
			});
			characterMapper = characterConfig.CreateMapper();
		}
	}
}
