using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public long Quantity { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
