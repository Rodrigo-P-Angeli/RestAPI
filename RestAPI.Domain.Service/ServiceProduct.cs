using RestAPI.Domain.Entities;
using RestAPI.Domain.Core.Interface.Services;
using RestAPI.Domain.Core.Interface.Repositories;

namespace RestAPI.Domain.Service
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}
