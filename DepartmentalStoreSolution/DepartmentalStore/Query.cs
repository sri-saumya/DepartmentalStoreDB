using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore
{
    public class Query
    {
        public static StoreContext context = new StoreContext();
        
        public static void QueryOnStaff()
        {
            Console.WriteLine("Query1 : Query Staff using name or phone number or both ");
            List<Staff> queryname = context.Staff.Where(s => s.FirstName.ToLower() == "mark" || s.PhoneNumber == "3453389234").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Salary" + "\t" + "Phone Number\n");
            queryname.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Salary} \t\t{i.PhoneNumber}");
            });

            Console.WriteLine("Query2 : Query on Staff - using Department");
           
        }
       
        public static void QueryOnProduct()
        {
            Console.WriteLine("Query3 a) : List of Products - Using Name ");
            List<Product> query1 = context.Product.Where(s => s.ProductName.ToLower() == "pen").ToList();
            Console.WriteLine("Name" + "\t" + "Manufacturer" + "\t\t\t" + "CP" + "\t" + "SP\n");
            query1.ForEach((i) =>
            {
                Console.WriteLine($"{i.ProductName} \t\t {i.Manufacturer}\t\t\t {i.CostPrice} \t\t{i.SellingPrice}");
            });

            Console.WriteLine("Query3 d) : List of Products -SP less than, greater than or between  ");
            List<Product> query2 = context.Product.Where(s => s.SellingPrice >= 12000).ToList();
            Console.WriteLine("Name" + "\t" + "Manufacturer" + "\t\t\t" + "SP\n");
            query2.ForEach((i) =>
            {
                Console.WriteLine($"{i.ProductName} \t\t {i.Manufacturer}\t\t\t{i.SellingPrice}");
            });



        }

        public static void QueryOnSupplier()
        {
            Console.WriteLine("Query7 a) : List of Suppliers - Using Name ");
            List<Supplier> query1 = context.Supplier.Where(s => s.FirstName.ToLower() == "raj").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Email" + "\t" + "Phone Number" + "\t" + "City\n");
            query1.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Email} \t\t{i.PhoneNumber} \t\t{i.City}");
            });

            Console.WriteLine("Query7 b) : List of Suppliers - Using Phone no");
            List<Supplier> query2 = context.Supplier.Where(s => s.PhoneNumber == "5566789345").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Email" + "\t" + "Phone Number" + "\t" + "City\n");
            query2.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Email} \t\t{i.PhoneNumber} \t\t{i.City}");
            });

            Console.WriteLine("Query7 c) : List of Suppliers - Using Email ");
            List<Supplier> query3 = context.Supplier.Where(s => s.Email == "meena@gmail.com").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Email" + "\t" + "Phone Number" + "\t" + "City\n");
            query3.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Email} \t\t{i.PhoneNumber} \t\t{i.City}");
            });

            Console.WriteLine("Query7 d) : List of Suppliers - Using City or State ");
            List<Supplier> query4 = context.Supplier.Where(s => s.City == "Lucknow" || s.State == "MP").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Email" + "\t" + "Phone Number" + "\t" + "City\n");
            query4.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Email} \t\t{i.PhoneNumber} \t\t{i.City}");
            });
        }

        public static void QueryOnProductOnBasisOfStock()
        {

        }

        public static void QueryOnProductWithCategory()
        {

        }



    }
}
