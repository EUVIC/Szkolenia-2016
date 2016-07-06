using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValarMorghulis.Common.Resources;

namespace ValarMorghulis.HybridUI.ViewModels
{
	public class CharacterDetailsViewModel
	{
		public int Id { get; set; }
        [Display(ResourceType = typeof(Labels), Name = "NameLabel")]
        public string Name { get; set; }
        [Display(ResourceType = typeof(Labels), Name = "GenderLabel")]
        public string Gender { get; set; }
        [Display(ResourceType = typeof(Labels), Name = "BornLabel")]
        public string Born { get; set; }
        [Display(ResourceType = typeof(Labels), Name = "DiedLabel")]
        public string Died { get; set; }
        [Display(ResourceType = typeof(Labels), Name = "CultureLabel")]
        public string CultureName { get; set; }
    }
}
