using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Infrastructure.ViewModels.Character;

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
				cfg.CreateMap<Character, CharacterDetailsViewModel>();
				cfg.CreateMap<Character, CharacterListElementViewModel>();
			});
			characterMapper = characterConfig.CreateMapper();
		}
	}
}
