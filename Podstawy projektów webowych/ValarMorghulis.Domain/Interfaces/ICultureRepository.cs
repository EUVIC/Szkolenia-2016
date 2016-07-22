using ValarMorghulis.Domain.Base;

namespace ValarMorghulis.Domain.Interfaces
{
	public interface ICultureRepository : IGenericRepository<Culture>
	{
		Culture GetSingle(int fooId);
	}
}
