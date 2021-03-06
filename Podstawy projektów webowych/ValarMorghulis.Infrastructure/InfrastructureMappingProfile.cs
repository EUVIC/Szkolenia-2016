﻿using AutoMapper;
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
    public class InfrastructureMappingProfile : Profile
    {
        public InfrastructureMappingProfile()
        {
			CreateMap<CharacterDTO, Character>();

			CreateMap<CharacterWithIdDTO, Character>();
			
			CreateMap<Culture, CultureDTO>();

            CreateMap<Character, CharacterDTO>();
			CreateMap<Character, CharacterWithIdDTO>();
		}
    }
}
