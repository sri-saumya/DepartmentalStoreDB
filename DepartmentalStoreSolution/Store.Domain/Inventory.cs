using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class Inventory
    {
        public long Id { get; set; }
        public long Quantity { get; set; }
        public Boolean InStock { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        

    }
}
