using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class SupplierProduct
    {
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
