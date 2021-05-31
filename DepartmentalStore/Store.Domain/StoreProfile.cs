using AutoMapper;
using Store.Domain.Model;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class StoreProfile : Profile
    {

        public StoreProfile()
        {
            this.CreateMap<Product, ProductModel>().ReverseMap();
            this.CreateMap<Category, CategoryModel>().ReverseMap();
            this.CreateMap<Inventory, InventoryModel>().ReverseMap();
            this.CreateMap<ProductCategory, ProductCategoryModel>().ReverseMap();
            this.CreateMap<Staff, StaffModel>();
            this.CreateMap<Address, AddressModel>();
            this.CreateMap<Department, DepartmentModel>();


        }
    }

}
