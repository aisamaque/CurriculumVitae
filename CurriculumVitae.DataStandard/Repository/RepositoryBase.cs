using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CurriculumVitae.DataStandard.Repository
{
    public class RespositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected CurriculumVitaeContext Db;

        public RespositoryBase(CurriculumVitaeContext context)
        {
            Db = context;
        }

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            var itens = Db.Set<TEntity>().Where(predicate).ToList();
            if (itens.Count  == 1)
            {
                itens[0] = GetRelated(itens.FirstOrDefault());
            }
            return itens;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return GetRelated(Db.Set<TEntity>().Find(id));
        }

        public void Remove(int id)
        {
            Remove(GetById(id));
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetRelated(TEntity obj)
        {
            return obj;
        }
    }
}
