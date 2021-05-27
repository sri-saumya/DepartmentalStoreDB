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
            var result = _context.Product.ToList();
            List<ProductModel> productModels = _mapper.Map<List<ProductModel>>(result);
            return productModels;
        }


        [HttpGet("{categoryname}")]
        public List<ProductModel> GetProductByCategory(string categoryname)
        {
            var res = (from p in _context.Product
                       join pc in _context.ProductCategory
                       on p.Id equals pc.ProductId
                       join c in _context.Category
                       on pc.CategoryId equals c.Id
                       where categoryname == c.CategoryName
                       select new ProductModel
                       {
                           CategoryName = c.CategoryName, ProductName = p.ProductName, ShortCode = p.ShortCode
                       }).ToList();
            return res;
        }

        [HttpGet("{instock}")]
        public List<ProductModel> GetInStockProduct(bool instock)
        {
            var res = (from p in _context.Product
                       join i in _context.Inventory
                       on p.Id equals i.ProductId
                       where instock == i.InStock
                       select new ProductModel
                       {  
                           ProductName = p.ProductName,ShortCode = p.ShortCode,
                           Quantity = i.Quantity
                       }).ToList();
            return res;
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


