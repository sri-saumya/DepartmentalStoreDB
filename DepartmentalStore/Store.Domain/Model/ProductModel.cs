using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string ShortCode { get; set; }
        public string Manufacturer { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }

        //public ProductModel()
        //{
        //    ProductCategories = new List<ProductCategoryModel>();

        //}
        public List<ProductCategoryModel> ProductCategories { get; set; }

        public InventoryModel Inventory { get; set; }
    }
}
