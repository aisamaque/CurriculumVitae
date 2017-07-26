using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CurriculumVitae.DomainStandard.Interfaces.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        void Dispose();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
