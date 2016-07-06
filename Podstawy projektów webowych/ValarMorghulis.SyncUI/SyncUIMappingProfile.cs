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
    public class SyncUIMappingProfile : Profile
    {
        public SyncUIMappingProfile()
        {
            CreateMap<CharacterDTO, CharacterDetailsViewModel>();
            CreateMap<CharacterDTO, UpdateCharacterViewModel>();
            CreateMap<CharacterListElementDTO, CharacterListElementViewModel>();
            CreateMap<CultureDTO, CultureSelectListItemViewModel>();

            CreateMap<UpdateCharacterViewModel, CharacterDTO>()
                .ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<CreateCharacterViewModel, CharacterDTO>();
        }
    }
}