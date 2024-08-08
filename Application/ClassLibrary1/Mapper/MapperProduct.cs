using RestAPI.Application.DTOs;
using RestAPI.Application.Interfaces.Mappers;
using RestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Application
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Description = productDto.Description,
                ManufacturingDate = productDto.ManufacturingDate,
                ExpirationDate = productDto.ExpirationDate,
                Active = productDto.Active,
                SupplierDescription = productDto.SupplierDescription,
                SupplierCode = productDto.SupplierCode,
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Description = product.Description,
                ManufacturingDate = product.ManufacturingDate,
                ExpirationDate = product.ExpirationDate,
                Active = product.Active,
                SupplierDescription = product.SupplierDescription,
                SupplierCode = product.SupplierCode,
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDto { 
                Id = c.Id, 
                Description = c.Description,
                ManufacturingDate = c.ManufacturingDate,
                ExpirationDate = c.ExpirationDate,
                Active = c.Active,
                SupplierDescription = c.SupplierDescription,
                SupplierCode = c.SupplierCode,
            } );
            return dto;
        }
    }
}
