using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Infrastructure.Models;

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
                //cfg.CreateMap<Character, CharacterDetailsViewModel>();
                //cfg.CreateMap<Character, CharacterListElementViewModel>();

                //// Culture
                //cfg.CreateMap<Culture, CultureSelectListItemViewModel>();

                // VM to Entity
                // Character
                cfg.CreateMap<CharacterDTO, Character>()
                .ForMember(d => d.Id, opt => opt.Ignore());

                // Culture
                cfg.CreateMap<Culture, CultureDTO>();

                // VM to Entity
                // Character
                cfg.CreateMap<Character, CharacterDTO>();
                cfg.CreateMap<Character, CharacterListElementDTO>();

            });
            characterMapper = characterConfig.CreateMapper();
        }
    }
}
