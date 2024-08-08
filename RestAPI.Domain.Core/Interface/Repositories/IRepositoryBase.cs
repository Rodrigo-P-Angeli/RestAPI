using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Core.Interface.Repositories
{
    public interface IRepositoryBase<TEntitiy> where TEntitiy : class
    {
        void add(TEntitiy obj);
        void update(TEntitiy obj);
        void remove(TEntitiy obj);
        IEnumerable<TEntitiy> GetAll();
        TEntitiy GetById(int id);
    }
}
