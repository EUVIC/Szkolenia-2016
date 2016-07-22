using ValarMorghulis.Domain.Base;

namespace ValarMorghulis.Domain.Interfaces
{
	public interface ICharacterRepository : IGenericRepository<Character>
	{
		Character GetSingle(int fooId);
	}
}
