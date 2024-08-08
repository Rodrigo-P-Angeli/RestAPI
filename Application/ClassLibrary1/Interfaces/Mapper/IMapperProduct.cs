using RestAPI.Application.DTOs;
using RestAPI.Domain.Entities;
using System.Collections.Generic;

namespace RestAPI.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto product);

        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        ProductDto MapperEntityToDto(Product product);
    }
}
