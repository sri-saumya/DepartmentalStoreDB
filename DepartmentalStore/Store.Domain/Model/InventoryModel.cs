using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Model
{
    public class InventoryModel
    {
        public long Quantity { get; set; }

        public Boolean InStock { get; set; }
    }
}
