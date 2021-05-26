using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class Product
    {
        public Product()
        {
            ProductCategories = new List<ProductCategory>();
            
        }
        public List<ProductCategory> ProductCategories { get; set; }
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ShortCode { get; set; }
        public string Manufacturer { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public Inventory Inventory { get; set; }

    }
}
