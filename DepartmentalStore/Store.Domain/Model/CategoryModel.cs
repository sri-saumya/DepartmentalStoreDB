using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            ProductCategories = new List<ProductCategoryModel>();
        }
        public List<ProductCategoryModel> ProductCategories { get; set; }
        public string CategoryName { get; set; }
    }
}
