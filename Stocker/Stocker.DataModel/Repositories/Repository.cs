using Stocker.DataModel.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Stocker.DataModel.Repositories
{
    public class Repository<T> :IRepository<T> where T : BaseEntity
    {
        StockerModel _Model;

        public Repository()
        {
            this._Model = new StockerModel();
        }

        public void Add(T entity)
        {
            this._Model.Set<T>().Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            this._Model.Set<T>().Remove(entity);
            Save();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return this._Model.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return this._Model.Set<T>();
        }

        public void Save()
        {
            this._Model.SaveChanges();
        }

        public void Update(T entity)
        {
            this._Model.Set<T>().Attach(entity);
            Save();
        }

        public void DeleteAll()
        {
            this._Model.Set<T>().RemoveRange(GetAll());
            Save();
        }
    }
}
