using RestAPI.Domain.Core.Interface.Repositories;
using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
