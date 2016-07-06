using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValarMorghulis.Infrastructure.Models;
using ValarMorghulis.SyncUI.ViewModels.Character;
using ValarMorghulis.SyncUI.ViewModels.Culture;

namespace ValarMorghulis.SyncUI
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
                cfg.CreateMap<CultureDTO, CultureSelectListItemViewModel>();

                cfg.CreateMap<UpdateCharacterViewModel, CharacterDTO>()
                    .ForMember(d => d.Id, opt => opt.Ignore());
                cfg.CreateMap<CreateCharacterViewModel, CharacterDTO>();

            });
            characterMapper = characterConfig.CreateMapper();
        }
    }
}