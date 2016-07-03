using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Infrastructure.ViewModels.Culture;

namespace ValarMorghulis.Infrastructure.ViewModels.Character
{
	public class CreateCharacterViewModel
	{
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Born { get; set; }
		public string Died { get; set; }
		public int CultureId { get; set; }
		public IEnumerable<CultureSelectListItemViewModel> CultureOptions { get; set; }
	}
}
