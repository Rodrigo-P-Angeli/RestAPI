using RestAPI.Application.DTOs;
using System.Collections.Generic;

namespace RestAPI.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDto productDto);
        void Update(ProductDto productDto);
        void Remove(ProductDto productDto);
        IEnumerable<ProductDto> GetAll(int? page, int? pageSize, bool? active);
        ProductDto GetById(int id);
    }
}
