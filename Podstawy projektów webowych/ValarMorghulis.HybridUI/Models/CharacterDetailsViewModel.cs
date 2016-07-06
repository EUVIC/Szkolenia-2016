﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.HybridUI.Models
{
	public class CharacterDetailsViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Born { get; set; }
		public string Died { get; set; }
        public int CultureId { get; set; }
    }
}
