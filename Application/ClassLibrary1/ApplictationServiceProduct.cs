using RestAPI.Application.DTOs;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Interfaces.Mappers;
using RestAPI.Domain.Core.Interface.Services;
using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Application
{
    public class ApplictationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplictationServiceProduct(IServiceProduct serviceProduct,
            IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }
        public void Add(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            if (IsValidExpirationDate(product))
            {
                throw new Exception("Data de vencimento é menor que fabricação");
            }
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll(int? page, int? pageSize, bool? active)
        {
            IEnumerable<Product> products = serviceProduct.GetAll();
            IList<Product> listProducts = new List<Product>(products);
            if (active.HasValue)
            {
                listProducts = listProducts.Where(c => c.Active == active.Value).ToList();
            }
            if (page.HasValue && pageSize.HasValue)
            {
                listProducts = listProducts.Skip(page.Value * pageSize.Value).Take(pageSize.Value).ToList();
            }
            return mapperProduct.MapperListProductsDto(listProducts);
        }

        public ProductDto GetById(int id)
        {
            return mapperProduct.MapperEntityToDto(serviceProduct.getById(id));
        }

        public void Remove(ProductDto productDto)
        {
            Product product = mapperProduct.MapperDtoToEntity(productDto);
            product.Active = false;
            serviceProduct.Update(product);
        }

        public void Update(ProductDto productDto)
        {
            Product product = mapperProduct.MapperDtoToEntity(productDto);
            if (IsValidExpirationDate(product))
            {
                throw new Exception("Data de vencimento é menor que fabricação");
            }
            serviceProduct.Update(product);
        }


        private bool IsValidExpirationDate(Product produtoDTO)
        {
            return (produtoDTO.ExpirationDate < produtoDTO.ManufacturingDate);
        }
    }
}
