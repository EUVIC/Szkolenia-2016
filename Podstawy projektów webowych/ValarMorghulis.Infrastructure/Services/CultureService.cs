using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.ViewModels.Culture;

namespace ValarMorghulis.Infrastructure.Services
{
	public class CultureService
	{
		private readonly ICultureRepository cultureRepository;

		public CultureService()
		{
			cultureRepository = new CultureRepository();
		}

		public IEnumerable<CultureSelectListItemViewModel> GetCultures()
		{
			IQueryable<Culture> entities = cultureRepository.GetAll();
			return AutoMapperConfiguration.characterMapper.Map<IEnumerable<CultureSelectListItemViewModel>>(entities);
		}
	}
}
