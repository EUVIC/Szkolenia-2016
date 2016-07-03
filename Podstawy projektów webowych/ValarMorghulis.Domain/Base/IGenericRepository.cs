using System;
using System.Linq;
using System.Linq.Expressions;

namespace ValarMorghulis.Domain.Base
{
	public interface IGenericRepository<T>: IRepository where T : class
	{
		IQueryable<T> GetAll();
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
		void Save();
	}
}
