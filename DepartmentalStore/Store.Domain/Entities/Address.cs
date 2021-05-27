using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public long StaffId { get; set; }
        public Staff Staff { get; set; }

    }
}
