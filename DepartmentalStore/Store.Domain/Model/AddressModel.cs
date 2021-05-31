using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class AddressModel
    {
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
      
    }
}
