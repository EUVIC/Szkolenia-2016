using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.HybridUI.Models;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.HybridUI
{
    public class AutoMapperConfiguration
    {
        public static IMapper characterMapper;
        public static IMapper houseMapper;

        public void Configure()
        {
            var characterConfig = new MapperConfiguration(cfg =>
            {
                //Entity to VM
                //Character
                cfg.CreateMap<CharacterDTO, CharacterDetailsViewModel>();
                cfg.CreateMap<CharacterDTO, UpdateCharacterViewModel>();
                cfg.CreateMap<CharacterListElementDTO, CharacterListElementViewModel>();

                cfg.CreateMap<UpdateCharacterViewModel, CharacterDTO>()
                    .ForMember(d => d.Id, opt => opt.Ignore());
                cfg.CreateMap<CreateCharacterViewModel, CharacterDTO>();

            });
            characterMapper = characterConfig.CreateMapper();
        }
    }
}
