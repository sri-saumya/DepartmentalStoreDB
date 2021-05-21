using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class Department
    {
        public long Id { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
