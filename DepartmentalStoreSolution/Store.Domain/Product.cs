using System;
using System.Collections.Generic;

namespace Store.Domain
{
    public class Product
    {
        public Product()
        {
            ProductCategories = new List<ProductCategory>();
            SupplierProduct = new List<SupplierProduct>();
        }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<SupplierProduct> SupplierProduct { get; set; }
        public long Id { get; set; }
        public string  ProductName { get; set; }
        public string ShortCode { get; set; }
        public string Manufacturer { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public ProductHistory ProductHistory { get; set; }
        public Inventory Inventory { get; set; }

    }
}
