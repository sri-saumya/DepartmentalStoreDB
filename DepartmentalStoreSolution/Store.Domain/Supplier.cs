using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class Supplier
    {
        public Supplier()
        {
            SupplierProduct = new List<SupplierProduct>();
        }
        public List<SupplierProduct> SupplierProduct { get; set; }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
    }
}
