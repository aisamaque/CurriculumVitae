using CurriculumVitae.DomainStandard.Interfaces.Application;
using CurriculumVitae.DomainStandard.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CurriculumVitae.ApplicationStandard
{
    public class Application<TEntity> : IDisposable, IApplication<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _application;

        public Application(IServiceBase<TEntity> application)
        {
            _application = application;
        }

        public void Add(TEntity obj)
        {
            _application.Add(obj);
        }

        public void Dispose()
        {
            _application.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _application.Find(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _application.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _application.GetById(id);
        }

        public void Remove(int id)
        {
            _application.Remove(id);
        }

        public void Update(TEntity obj)
        {
            _application.Update(obj);
        }
    }
}
