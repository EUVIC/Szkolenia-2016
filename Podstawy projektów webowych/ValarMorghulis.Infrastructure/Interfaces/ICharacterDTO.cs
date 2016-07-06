using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.Infrastructure.Interfaces
{
	public interface ICharacterDTO
	{
		string Name { get; set; }
		string Gender { get; set; }
		string Born { get; set; }
		string Died { get; set; }
		string CultureName { get; set; }
		int CultureId { get; set; }
	}
}
