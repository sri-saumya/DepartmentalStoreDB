using Store.Data;
using Store.Domain;
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
            //var res = context.Supplier.Join(context.Product,
            //                 supp => supp.Id,
            //                 pro => pro.Id,
            //                 (supp, pro) => new {
            //                     supp = supp.FirstName,
            //                     supp2 = supp.LastName,
            //                     prod = pro.ProductName,
            //                     prod2 = pro.Manufacturer
            //                 });
            //Console.WriteLine("FirstName" + "\t\t"+"LastName" + "\t\t" + "ProductName" + "\t\t" + "Manufacturer \n");
            //foreach (var i in res)
            //{
            //    Console.WriteLine($"{ i.supp} \t\t{ i.supp2} \t\t{ i.prod} \t\t { i.prod2}");
            //}
        }

        public static void SupplyAfterParticularDate()
        {
            Console.WriteLine("Query8 : Supply after a particular Date");
            List<ProductHistory> query2 = context.ProductHistory.Where(s => s.SupplyDate >new DateTime(2005, 03, 11)).ToList();
            Console.WriteLine("SupplyDate" + "\t\t" + "Quantity" + "\t\t\t" + "ProductName\n");
            query2.ForEach((i) =>
            {
                Console.WriteLine($"{i.SupplyDate} \t\t {i.Quantity}\t\t\t{i.ProductId}");
            });

        }

        public static void SupplyBeforeParticularDate()
        {
            Console.WriteLine("Query8 : Supply Before a particular Date  ");
            List<ProductHistory> query2 = context.ProductHistory.Where(s => s.SupplyDate < new DateTime(2005, 03, 11)).ToList();
            Console.WriteLine("SupplyDate" + "\t\t" + "Quantity" + "\t\t\t" + "ProductName\n");
            query2.ForEach((i) =>
            {
                Console.WriteLine($"{i.SupplyDate} \t\t {i.Quantity}\t\t\t{i.ProductId}");
            });
        }
    }
}
