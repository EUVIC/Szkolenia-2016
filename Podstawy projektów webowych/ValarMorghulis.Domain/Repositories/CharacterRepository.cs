using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Domain.Base;
using ValarMorghulis.Domain.Interfaces;

namespace ValarMorghulis.Domain.Repositories
{
	public class CharacterRepository :
	GenericRepository<VMDBContainer, Character>, ICharacterRepository
	{
		public Character GetSingle(int id)
		{
			var query = GetAll().FirstOrDefault(x => x.Id == id);
			return query;
		}
	}
}
