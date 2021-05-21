using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class ProductHistory
    {
        public long Id { get; set; }
        public long Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SupplyDate { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }

    }
    
    
}
