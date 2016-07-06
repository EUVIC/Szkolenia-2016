using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.HybridUI.Models
{
	public class CreateCharacterViewModel
	{
        [Required]
		public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Born { get; set; }
        [Required]
        public string Died { get; set; }
        [Required]
        public int CultureId { get; set; }
	}
}
