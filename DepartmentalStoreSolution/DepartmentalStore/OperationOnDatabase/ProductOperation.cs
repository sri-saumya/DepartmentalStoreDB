using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore.OperationOnDatabase
{
    public class ProductOperation
    {
        public static StoreContext context = new StoreContext();
        public static void ProductByName()
        {
            Console.WriteLine("Query3 a) : List of Products - Using Name ");
            List<Product> query1 = context.Product.Where(s => s.ProductName.ToLower() == "pen").ToList();
            Console.WriteLine("Name" + "\t\t" + "Manufacturer" + "\t\t" + "CP" + "\t" + "SP\n");
            query1.ForEach((i) =>
            {
                Console.WriteLine($"{i.ProductName} \t\t {i.Manufacturer}\t\t\t {i.CostPrice} \t\t{i.SellingPrice}");
            });

            Console.WriteLine("Query3 c) : List of Products - Using stock ");
            var res2 = context.Product.Join(context.Inventory,
                             pro => pro.Id,
                             inv => inv.Id,
                             (pro, inv) => 
                             new{
                                 prods = pro.ProductName,
                                 q = inv.Quantity
                             });

            foreach (var val in res2)
            {
                Console.WriteLine("Product Name: {0} \t Quantity: {1}", val.prods, val.q);
            }  
        }

        public static void ProductByPrice()
        {
            Console.WriteLine("Query3 d) : List of Products -SP less than, greater than or between  ");
            List<Product> query2 = context.Product.Where(s => s.SellingPrice >= 12000).ToList();
            Console.WriteLine("Name" + "\t\t" + "Manufacturer" + "\t\t\t" + "SP\n");
            query2.ForEach((i) =>
            {
                Console.WriteLine($"{i.ProductName} \t\t {i.Manufacturer}\t\t\t{i.SellingPrice}");
            });

        }

        public static void ProductWithinCategory()
        {
            Console.WriteLine("Query3 b) : List of Products - Using Category ");
            var res = context.Product.Join(context.Category,
                             pro => pro.Id,
                             cat => cat.Id,
                             (pro, cat) => new {
                                 prod = pro.ProductName,
                                 cat = cat.CategoryName
                             });
            Console.WriteLine("Name" + "\t\t" + "Category \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{ i.prod} \t\t { i.cat}");
            }
        }


        public static void ProductOutOfStock()
        {
            int count = 0;
            var productoutofstock =
            from prod in context.Product
            join inv in context.Inventory on prod.Id equals inv.ProductId
            where inv.InStock == false
            select prod;
            Console.WriteLine("Name" + "\t\t" + "Manufacturer");
            foreach (var item in productoutofstock)
            {
                Console.WriteLine($"{item.ProductName} \t\t {item.Manufacturer}");
                count++;
            }
            Console.WriteLine("count product which is out of stock{0}  : ", count);

        }

        public static void ProductInStock()
        {
            int count = 0;
            var productinstock =
            from prod in context.Product
            join inv in context.Inventory on prod.Id equals inv.ProductId
            where inv.InStock == true
            select prod;
            Console.WriteLine("Name" + "\t\t" + "Manufacturer");
            foreach (var item in productinstock)
            {
                Console.WriteLine($"{item.ProductName} \t\t {item.Manufacturer}");
                count++;
            }
            Console.WriteLine("count product which is in stock{0}  : ", count);
        }
    }
}
