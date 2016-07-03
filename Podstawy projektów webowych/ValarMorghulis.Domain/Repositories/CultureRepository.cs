using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain.Base;
using ValarMorghulis.Domain.Interfaces;

namespace ValarMorghulis.Domain.Repositories
{
	public class CultureRepository :
	GenericRepository<VMDBContainer, Culture>, ICultureRepository
	{
		public CultureRepository()
			: base()
		{
		}
		public CultureRepository(IRepository existingRepository)
			: base(existingRepository)
		{
		}

		public Culture GetSingle(int id)
		{
			var query = GetAll().FirstOrDefault(x => x.Id == id);
			return query;
		}
	}
}
