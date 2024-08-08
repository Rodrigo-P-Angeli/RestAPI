using RestAPI.Domain.Core.Interface.Repositories;
using RestAPI.Domain.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
   
        public void Add(TEntity obj)
        {
            repository.add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity getById(int obj)
        {
            return repository.GetById(obj);
        }

        public void Remove(TEntity obj)
        {
            repository.remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.update(obj);
        }
    }
}
