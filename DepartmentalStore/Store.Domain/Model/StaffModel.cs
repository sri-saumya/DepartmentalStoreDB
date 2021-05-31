using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class StaffModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public AddressModel Address { get; set; }
        public DepartmentModel Department { get; set; }




    }
}
