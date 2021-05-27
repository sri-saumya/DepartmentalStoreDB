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
            this.CreateMap<Product, ProductModel>();
            this.CreateMap<Staff, StaffModel>();

        }
    }

}
