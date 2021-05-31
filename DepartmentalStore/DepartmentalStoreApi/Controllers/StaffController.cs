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
    public class StaffController : ControllerBase
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public StaffController(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public List<StaffModel> GetStaff()
        {
            var staff = _context.Staff.Include(d => d.Department).Include(a => a.Address);
            var res = staff.ToList();
            return _mapper.Map<List<StaffModel>>(res);
       
        }


        [HttpGet("role")]
        public List<StaffModel> GetStaffByDepartment(string dep, bool includeAddress = false)
        {
            IQueryable<Staff>  staff = _context.Staff.Where(d => d.Department.DepartmentName == dep).Include(d => d.Department);

            if (includeAddress) {
                staff = staff.Include(a => a.Address);
            }
            List<Staff> res = staff.ToList();
            return _mapper.Map<List<StaffModel>>(res);
        }


        [HttpPost()]
        public Staff createItem(Staff staff)
        {
            _context.Staff.Add(staff);
            _context.SaveChanges();
            return staff;
        }


        [HttpPut("{id}")]
        public Staff UpdateStaff(Staff staff)
        {
            _context.Entry(staff).State = EntityState.Modified;
            _context.SaveChanges();
            return staff;
        }
    }
}
