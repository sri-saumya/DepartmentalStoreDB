using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Data.Infrastructure;
using Store.Domain.Model;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;

        public StoreController(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //----------------------------product-----------------------------------------------------------------

        [HttpGet()]
        public List<ProductModel> GetProduct()
        {
            var result = _context.Product.Include(i => i.Inventory).ToList();
            List<ProductModel> productModel = _mapper.Map<List<ProductModel>>(result);
            return productModel;
        }

        [HttpGet("product-stock")]
        public List<ProductModel> GetInStockProduct(bool instock)
        {
            var result = _context.Product.Include(i => i.Inventory).Where(s=>s.Inventory.InStock == instock).ToList();
            List<ProductModel> productModel = _mapper.Map<List<ProductModel>>(result);
            return productModel;
        }


        [HttpGet("product-category")]
        public List<ProductCategoryModel> GetProductByCategory(string categoryname)
        {
            var pro = _context.ProductCategory.Include(c => c.Category).Include(p => p.Product)
                      .Where(cn => cn.Category.CategoryName == categoryname);
            var result = pro.ToList();
            return _mapper.Map<List<ProductCategoryModel>>(result);
        }


        [HttpPost()]
        public Product createItem(Product item)
        {
            _context.Product.Add(item);
            _context.SaveChanges();
            return item;
        }


        [HttpPut("{id}")]
        public Product UpdateProduct(Product item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }

    }
}


