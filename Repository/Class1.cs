using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase <T>: IRepositoryBase<T> where T: class
    {
        protected RepositoryContext RepositoryContext;

        public RepositoryBase (RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }


        public IQueryable<T> FindAll(bool TrackChanges)
        {
            !TrackChanges ? RepositoryContext.Set<T>()
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool TrackChanges)
        {
            throw new NotImplementedException();
        }
        public void Create(T entity)
        {
           
        }
        public void Update(T entity)
        {
            
        }
        public void Delete(T entity)
        {

        }

    }
}
