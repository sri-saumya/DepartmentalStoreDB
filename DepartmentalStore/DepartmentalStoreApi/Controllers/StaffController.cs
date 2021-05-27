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

        //----------------------------staff-----------------------------------------------------------------

        [HttpGet]
        public List<StaffModel> GetStaff()
        {
            var res = (from d in _context.Department
                          join s in _context.Staff
                          on d.Id equals s.DepartmentId
                          join a in _context.Address
                          on s.Id equals a.StaffId
                          select new StaffModel
                          {
                              FirstName = s.FirstName,LastName = s.LastName,  Gender = s.Gender, Salary = s.Salary, 
                              DepartmentName = d.DepartmentName,
                              AddressLine1 = a.AddressLine1,City = a.City,State = a.State, PinCode = a.PinCode
                          }).ToList();
            return res;
        }


        [HttpGet("{dep}")]
        public List<StaffModel> GetStaffByDepartment(string dep)
        {
            var res = (from d in _context.Department
                          join s in _context.Staff
                          on d.Id equals s.DepartmentId
                          where dep == d.DepartmentName
                          select new StaffModel
                          {
                              FirstName = s.FirstName,LastName = s.LastName,Gender = s.Gender, Salary = s.Salary,
                              DepartmentName = d.DepartmentName
                          }).ToList();
            return res;
                       
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
