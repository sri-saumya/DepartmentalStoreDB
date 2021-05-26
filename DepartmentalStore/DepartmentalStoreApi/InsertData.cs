using Store.Data.Infrastructure;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreApi
{
    public static class InsertData
    {
    //    //public static StoreContext context = new StoreContext();

    //    //Insert Data on Tables
    //    public static void AddDepartment()
    //    {
    //        var data1 = new Department { DepartmentName = "AccountManagement", Description = "Manage account related operations" };
    //        var data2 = new Department { DepartmentName = "InventoryManagement", Description = "Manage stock turn overs" };
    //        var data3 = new Department { DepartmentName = "OrderManagement", Description = "Manage purchase order and supplier details" };
    //        var data4 = new Department { DepartmentName = "Manager", Description = "Manage" };
    //        var data5 = new Department { DepartmentName = "Hygiene", Description = "Maintain hygiene in store" };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
    //        context.SaveChanges();
    //    }

    //    public static void AddStaff()
    //    {
    //        var data1 = new Staff { FirstName = "John", LastName = "Paul", Gender = "Male", PhoneNumber = "3456789234", Salary = 90000, DepartmentId = 1 };
    //        var data2 = new Staff { FirstName = "Mark", LastName = "Paul", Gender = "Male", PhoneNumber = "3477789234", Salary = 3000, DepartmentId = 2 };
    //        var data3 = new Staff { FirstName = "Laura", LastName = "Boss", Gender = "Female", PhoneNumber = "3453389234", Salary = 56000, DepartmentId = 3 };
    //        var data4 = new Staff { FirstName = "Riya", LastName = "Jatt", Gender = "Female", PhoneNumber = "3459989234", Salary = 98000, DepartmentId = 1 };
    //        var data5 = new Staff { FirstName = "Teena", LastName = "Josh", Gender = "Female", PhoneNumber = "3455789234", Salary = 1000, DepartmentId = 4 };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
    //        context.SaveChanges();
    //    }

    //    public static void AddAddress()
    //    {
    //        var data1 = new Address { AddressLine1 = "Goregaon East", AddressLine2 = "Back of Hotel Taj", City = "Mumbai", State = "Maharastra", Country = "India", PinCode = "376456", StaffId = 1 };
    //        var data2 = new Address { AddressLine1 = "North America", AddressLine2 = "Front Gate ", City = "Lucknow", State = "UP", Country = "India", PinCode = "379563", StaffId = 2 };
    //        var data3 = new Address { AddressLine1 = "291 -H Block", AddressLine2 = "Jaipur 67 H Block", City = "Jaipur", State = "MP", Country = "India", PinCode = "224563", StaffId = 3 };
    //        var data4 = new Address { AddressLine1 = "Goregaon West", AddressLine2 = "Back of Hotel Taj", City = "Mumbai", State = "UP", Country = "India", PinCode = "904563", StaffId = 4 };
    //        var data5 = new Address { AddressLine1 = "69-K block", AddressLine2 = "Near Hostel Taj", City = "Gorakhpur", State = "UP", Country = "India", PinCode = "983763", StaffId = 5 };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
    //        context.SaveChanges();
    //    }
    //    public static void AddProduct()
    //    {
    //        var data5 = new Product { ProductName = "Bag", ShortCode = "bag", Manufacturer = "American Tourister", CostPrice = 11000, SellingPrice = 12000 };
    //        var data4 = new Product { ProductName = "Pen", ShortCode = "pen", Manufacturer = "Nataraj", CostPrice = 24.0M, SellingPrice = 26 };
    //        var data3 = new Product { ProductName = "Cheese", ShortCode = "che", Manufacturer = "Amul", CostPrice = 110, SellingPrice = 120 };
    //        var data2 = new Product { ProductName = "Car", ShortCode = "car", Manufacturer = "Audi", CostPrice = 600000, SellingPrice = 700000 };
    //        var data1 = new Product { ProductName = "Shoap", ShortCode = "sho", Manufacturer = "Dove", CostPrice = 100, SellingPrice = 200 };
    //        var data6 = new Product { ProductName = "Milk", ShortCode = "mil", Manufacturer = "Amul", CostPrice = 110, SellingPrice = 120 };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5); context.Add(data6);
    //        context.SaveChanges();
    //    }
    //    public static void AddCategory()
    //    {
    //        var data5 = new Category { CategoryName = "Stationary", ShortCode = "sta" };
    //        var data4 = new Category { CategoryName = "Grocery", ShortCode = "gro" };
    //        var data3 = new Category { CategoryName = "Dairy", ShortCode = "dai" };
    //        var data2 = new Category { CategoryName = "Four Wheeler", ShortCode = "fou" };
    //        var data1 = new Category { CategoryName = "Travel", ShortCode = "tra" };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
    //        context.SaveChanges();
    //    }

    //    public static void AddProductCategory()
    //    {
    //        var data1 = new ProductCategory { ProductId = 1, CategoryId = 1 };
    //        var data2 = new ProductCategory { ProductId = 2, CategoryId = 1 };
    //        var data3 = new ProductCategory { ProductId = 3, CategoryId = 3 };
    //        var data4 = new ProductCategory { ProductId = 5, CategoryId = 3 };
    //        var data5 = new ProductCategory { ProductId = 4, CategoryId = 2 };
    //        var data6 = new ProductCategory { ProductId = 4, CategoryId = 4 };
    //        var data7 = new ProductCategory { ProductId = 4, CategoryId = 5 };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5); context.Add(data6); context.Add(data7);
    //        context.SaveChanges();
    //    }
    //    public static void AddInventory()
    //    {
    //        var data1 = new Inventory { Quantity = 300, InStock = true, ProductId = 1 };
    //        var data2 = new Inventory { Quantity = 8900, InStock = true, ProductId = 3 };
    //        var data3 = new Inventory { Quantity = 0, InStock = false, ProductId = 2 };
    //        var data4 = new Inventory { Quantity = 2000, InStock = true, ProductId = 4 };
    //        var data5 = new Inventory { Quantity = 10, InStock = true, ProductId = 5 };

    //        context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
    //        context.SaveChanges();
    //    }

           
    }
}
