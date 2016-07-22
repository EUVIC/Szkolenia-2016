using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValarMorghulis.Domain.Base
{
	public abstract class GenericRepository<C, T> :
		IGenericRepository<T> where T : class where C : DbContext, new()
	{
		private readonly C _entities;
		public C Context
		{
			get { return _entities; }
		}

		public GenericRepository()
		{
			_entities = new C();
		}

		public GenericRepository(IRepository existingRepository)
		{
			_entities = (existingRepository as GenericRepository<C, T>).Context;
		}

		public virtual IQueryable<T> GetAll()
		{

			IQueryable<T> query = _entities.Set<T>();
			return query;
		}

		public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
		{

			IQueryable<T> query = _entities.Set<T>().Where(predicate);
			return query;
		}

		public virtual void Add(T entity)
		{
			_entities.Set<T>().Add(entity);
		}

		public virtual void Delete(T entity)
		{
			_entities.Set<T>().Remove(entity);
		}

		public virtual void Edit(T entity)
		{
			_entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
		}

		public virtual void Save()
		{
			_entities.SaveChanges();
		}
	}
}
