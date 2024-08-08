using System;

namespace RestAPI.Domain.Entities
{
    public class Product : Base
    {
        public string Description { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
        public string SupplierDescription { get; set; }
        public int SupplierCode { get; set; }
    }
}
