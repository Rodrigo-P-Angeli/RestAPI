using System;

namespace RestAPI.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
        public string SupplierDescription { get; set; }
        public int SupplierCode { get; set; }
    }
}
