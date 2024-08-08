using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Core.Interface.Services
{
    public interface IServiceBase<TEntitiy> where TEntitiy : class
    {
        void Add(TEntitiy obj);
        void Update(TEntitiy obj);
        void Remove(TEntitiy obj);
        IEnumerable<TEntitiy> GetAll();
        TEntitiy getById(int obj);
    }
}
