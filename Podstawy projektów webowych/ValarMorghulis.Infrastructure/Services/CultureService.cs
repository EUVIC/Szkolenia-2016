using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.Infrastructure.Services
{
	public class CultureService
	{
		private readonly ICultureRepository cultureRepository;

		public CultureService()
		{
			cultureRepository = new CultureRepository();
		}

		public IEnumerable<CultureDTO> GetCultures()
		{
			IQueryable<Culture> entities = cultureRepository.GetAll();
			return Mapper.Map<IEnumerable<CultureDTO>>(entities);
		}
	}
}
