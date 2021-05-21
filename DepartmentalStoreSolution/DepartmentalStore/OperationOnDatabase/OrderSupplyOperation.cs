using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore.OperationOnDatabase
{
    public class OrderSupplyOperation
    {
        public static StoreContext context = new StoreContext();
        public static void BySupplierName()
        {
            Console.WriteLine("Query8");
            var res = context.Supplier.Join(context.Product,
                             e1 => e1.Id,
                             e3 => e3.Id,
                             (e1, e3) => new {
                                 supp = e1.FirstName,
                                 supp2 = e1.LastName,
                                 prod = e3.ProductName,
                                 prod2 = e3.Manufacturer
                             });
            Console.WriteLine("FirstName" + "\t\t"+"LastName" + "\t\t" + "ProductName" + "\t\t" + "Manufacturer \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{ i.supp} \t\t{ i.supp2} \t\t{ i.prod} \t\t { i.prod2}");
            }
        }

        public static void SupplyAfterParticularDate()
        {

        }

        public static void SupplyBeforeParticularDate()
        {

        }
    }
}
