using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Infrastructure.Interfaces;

namespace ValarMorghulis.Infrastructure.Models
{
	public class CharacterDTO : ICharacterDTO
	{
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Born { get; set; }
		public string Died { get; set; }
		public string CultureName { get; set; }
		public int CultureId { get; set; }
	}
}
