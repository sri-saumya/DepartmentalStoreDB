using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class Staff
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public long DepartmentId { get; set; }
        public Address Address { get; set; }
        public Department Department { get; set; }
        
    }
}
