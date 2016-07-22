using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.HybridUI.ViewModels;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.HybridUI
{
    public class HybridUIMappingProfile : Profile
    {
        public HybridUIMappingProfile()
        {
            CreateMap<CharacterWithIdDTO, CharacterDetailsViewModel>();
            CreateMap<CharacterWithIdDTO, UpdateCharacterViewModel>();
            CreateMap<CharacterWithIdDTO, CharacterListElementViewModel>();

            CreateMap<UpdateCharacterViewModel, CharacterDTO>();
            CreateMap<CreateCharacterViewModel, CharacterDTO>();
        }
    }
}
