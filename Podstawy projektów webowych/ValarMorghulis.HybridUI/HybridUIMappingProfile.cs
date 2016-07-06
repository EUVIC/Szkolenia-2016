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
    public class HybridUIMappingProfile : Profile
    {
        public HybridUIMappingProfile()
        {
            CreateMap<CharacterDTO, CharacterDetailsViewModel>();
            CreateMap<CharacterDTO, UpdateCharacterViewModel>();
            CreateMap<CharacterListElementDTO, CharacterListElementViewModel>();

            CreateMap<UpdateCharacterViewModel, CharacterDTO>()
                .ForMember(d => d.Id, opt => opt.Ignore());
            CreateMap<CreateCharacterViewModel, CharacterDTO>();
        }
    }
}
