using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.Common.Exceptions
{
	public class CharacterNameAlreadyTakenException : Exception
	{
		public CharacterNameAlreadyTakenException() { }
		public CharacterNameAlreadyTakenException(string message) : base(message) { }
		public CharacterNameAlreadyTakenException(string message, Exception inner) : base(message, inner) { }
	}
}
