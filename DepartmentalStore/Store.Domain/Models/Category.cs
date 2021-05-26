using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class Category
    {

        public Category()
        {
            ProductCategories = new List<ProductCategory>();
        }
        public List<ProductCategory> ProductCategories { get; set; }
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string ShortCode { get; set; }

    }
}
