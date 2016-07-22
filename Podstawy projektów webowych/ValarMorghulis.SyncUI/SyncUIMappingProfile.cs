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
			CreateMap<CharacterWithIdDTO, CharacterDetailsViewModel>();
			CreateMap<CharacterWithIdDTO, UpdateCharacterViewModel>();			
			CreateMap<CharacterWithIdDTO, CharacterListElementViewModel>();

			CreateMap<CultureDTO, CultureSelectListItemViewModel>();

			CreateMap<UpdateCharacterViewModel, CharacterWithIdDTO>();

			CreateMap<CreateCharacterViewModel, CharacterDTO>();
		}
	}
}