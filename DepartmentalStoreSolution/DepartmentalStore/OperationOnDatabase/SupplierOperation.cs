using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore.OperationOnDatabase
{
    public class SupplierOperation
    {
        public static StoreContext context = new StoreContext();
        public static void SupplierDetails()
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



    }
}
