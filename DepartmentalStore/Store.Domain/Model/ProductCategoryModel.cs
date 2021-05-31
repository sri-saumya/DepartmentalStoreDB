using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class ProductCategoryModel
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public ProductModel Product { get; set; }
        public CategoryModel Category { get; set; }
    }
}

