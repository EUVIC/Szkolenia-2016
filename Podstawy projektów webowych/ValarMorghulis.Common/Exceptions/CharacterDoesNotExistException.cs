using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.Common.Exceptions
{
	public class CharacterDoesNotExistException : Exception
	{
		public CharacterDoesNotExistException() { }
		public CharacterDoesNotExistException(string message) : base(message) { }
		public CharacterDoesNotExistException(string message, Exception inner) : base(message, inner) { }
	}
}
