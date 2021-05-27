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

        public string DepartmentName { get; set; }

        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }

    }
}
