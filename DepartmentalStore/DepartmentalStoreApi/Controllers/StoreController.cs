using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Data.Infrastructure;
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

        public StoreController(StoreContext context)
        {
            _context = context;
        }

        //----------------------------product-----------------------------------------------------------------

        [HttpGet("getproduct")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await _context.Product.ToListAsync();
        }


        [HttpGet("getproductbyid/{id}")]
        public async Task<ActionResult<Product>> GetProductById(long id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        [HttpGet("getproductbycode/{code}")]
        public async Task<ActionResult<Product>> GetProductByCode(string code)
        {
            var product = await _context.Product.FindAsync(code);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        [HttpPost("addproduct")]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }


        [HttpPut("updateproduct/{id}")]
        public Product UpdateProduct(Product item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }




        //----------------------------staff-----------------------------------------------------------------

        [HttpGet("getstaff")]
        public async Task<ActionResult<IEnumerable<Staff>>> GetStaffDetails()
        {
            return await _context.Staff.ToListAsync();
        }


        [HttpGet("getstaffbyid/{id}")]
        public async Task<ActionResult<Staff>> GetStaffById(long id)
        {
            var staff = await _context.Staff.FindAsync(id);

            if (staff == null)
            {
                return NotFound();
            }

            return staff;
        }


        [HttpGet("getstaffbyrole/{depId}")]
        public async Task<ActionResult<Staff>> GetStaffByRole(long dep)
        {
            var staff = await _context.Staff.FindAsync(dep);

            if (staff == null)
            {
                return NotFound();
            }

            return staff;
        }


        [HttpPost("addstaff")]
        public async Task<ActionResult<Staff>> AddStaff(Staff staff)
        {
            _context.Staff.Add(staff);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }


        [HttpPut("updatestaff/{id}")]
        public Staff UpdateStaff(Staff staff)
        {
            _context.Entry(staff).State = EntityState.Modified;
            _context.SaveChanges();
            return staff;
        }
    }
}


