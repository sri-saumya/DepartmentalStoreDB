using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore
{
    public static class InsertData
    {
        public static StoreContext context = new StoreContext();

        //Insert Data on Tables
        public static void AddDepartment()
        {
            var data1 = new Department { DepartmentName = "AccountManagement", Description = "Manage account related operations" };
            var data2 = new Department { DepartmentName = "InventoryManagement", Description = "Manage stock turn overs" };
            var data3 = new Department { DepartmentName = "OrderManagement", Description = "Manage purchase order and supplier details" };
            var data4 = new Department { DepartmentName = "Manager", Description = "Manage" };
            var data5 = new Department { DepartmentName = "Hygiene", Description = "Maintain hygiene in store" };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }

        public static void AddStaff()
        {
            var data1 = new Staff { FirstName="John",LastName="Paul",Gender="Male",PhoneNumber="3456789234",Salary=90000,DepartmentId=1};
            var data2 = new Staff { FirstName = "Mark", LastName = "Paul", Gender = "Male", PhoneNumber = "3477789234", Salary = 3000, DepartmentId = 2 };
            var data3 = new Staff { FirstName = "Laura", LastName = "Boss", Gender = "Female", PhoneNumber = "3453389234", Salary = 56000, DepartmentId = 3 };
            var data4 = new Staff { FirstName = "Riya", LastName = "Jatt", Gender = "Female", PhoneNumber = "3459989234", Salary = 98000, DepartmentId = 1 };
            var data5 = new Staff { FirstName = "Teena", LastName = "Josh", Gender = "Female", PhoneNumber = "3455789234", Salary = 1000, DepartmentId = 4 };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }

        public static void AddAddress()
        {
            var data1 = new Address { AddressLine1="Goregaon East" , AddressLine2 ="Back of Hotel Taj",City="Mumbai",State="Maharastra",Country="India",PinCode="376456",StaffId=1};
            var data2 = new Address { AddressLine1 = "North America", AddressLine2 = "Front Gate ", City = "Lucknow", State = "UP", Country = "India", PinCode = "379563", StaffId = 2 };
            var data3 = new Address { AddressLine1 = "291 -H Block", AddressLine2 = "Jaipur 67 H Block", City = "Jaipur", State = "MP", Country = "India", PinCode = "224563", StaffId = 3 };
            var data4 = new Address { AddressLine1 = "Goregaon West", AddressLine2 = "Back of Hotel Taj", City = "Mumbai", State = "UP", Country = "India", PinCode = "904563", StaffId = 4 };
            var data5 = new Address { AddressLine1 = "69-K block", AddressLine2 = "Near Hostel Taj", City = "Gorakhpur", State = "UP", Country = "India", PinCode = "983763", StaffId = 5 };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }
        public static void AddProduct()
        {
            var data1 = new Product { ProductName = "Bag", ShortCode = "bag", Manufacturer = "American Tourister", CostPrice = 11000, SellingPrice = 12000 };
            var data2 = new Product { ProductName = "Pen", ShortCode = "pen", Manufacturer = "Nataraj", CostPrice = 24.0M, SellingPrice = 26 };
            var data3 = new Product { ProductName = "Cheese", ShortCode = "che", Manufacturer = "Amul", CostPrice = 110, SellingPrice = 120 };
            var data4 = new Product { ProductName = "Car", ShortCode = "car", Manufacturer = "Audi", CostPrice = 600000, SellingPrice = 700000 };
            var data5 = new Product { ProductName = "Shoap", ShortCode = "sho", Manufacturer = "Dove", CostPrice = 100, SellingPrice = 200 };
            var data6 = new Product { ProductName = "Milk", ShortCode = "mil", Manufacturer = "Amul", CostPrice = 110, SellingPrice = 120 };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5); context.Add(data6);
            context.SaveChanges();
        }
        public static void AddCategory()
        {
            var data1 = new Category { CategoryName = "Stationary", ShortCode = "sta" };
            var data2 = new Category { CategoryName = "Grocery", ShortCode = "gro" };
            var data3 = new Category { CategoryName = "Dairy", ShortCode = "dai" };
            var data4 = new Category { CategoryName = "Four Wheeler", ShortCode = "fou" };
            var data5 = new Category { CategoryName = "Travel", ShortCode = "tra" };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }

        public static void AddProductCategory()
        {
            var data1 = new ProductCategory { ProductId = 1, CategoryId = 1 };
            var data2 = new ProductCategory { ProductId = 2, CategoryId = 4 };
            var data3 = new ProductCategory { ProductId = 4, CategoryId = 5 };
            var data4 = new ProductCategory { ProductId = 5, CategoryId = 2 };
            var data5 = new ProductCategory { ProductId = 3, CategoryId = 3 };
            var data6 = new ProductCategory { ProductId = 2, CategoryId = 1 };
            var data7 = new ProductCategory { ProductId = 6, CategoryId = 3 };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5); context.Add(data6); context.Add(data7);
            context.SaveChanges();
        }
        public static void AddInventory()
        {
            var data1 = new Inventory {Quantity=300,InStock=true,ProductId=1 };
            var data2 = new Inventory { Quantity = 8900, InStock = true, ProductId = 3 };
            var data3 = new Inventory { Quantity = 0, InStock = false, ProductId = 2 };
            var data4 = new Inventory { Quantity = 2000, InStock = true, ProductId = 4 };
            var data5 = new Inventory { Quantity = 10, InStock = true, ProductId = 5 };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }

        public static void AddSupplier()
        {
            var data1 = new Supplier { FirstName ="Meena",LastName="Rana",Gender="Female",PhoneNumber="5566789345",Email="meena@gmail.com",City="Delhi",State="UP"};
            var data2 = new Supplier { FirstName = "Rajveer", LastName = "Singh", Gender = "Male", PhoneNumber = "7753338901", Email = "rajveer@gmail.com", City = "Bhopal", State = "MP" };
            var data3 = new Supplier { FirstName = "Raj", LastName = "Kumar", Gender = "Male", PhoneNumber = "9954238901", Email = "raj@gmail.com", City = "Lucknow", State = "UP" };
            var data4 = new Supplier { FirstName = "Hina", LastName = "Khan", Gender = "Female", PhoneNumber = "8854238901", Email = "hina@gmail.com", City = "Indore", State = "MP" };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); 
            context.SaveChanges();
        }
        public static void AddSupplierProduct()
        {
            var data1 = new SupplierProduct {SupplierId=1,ProductId= 2};
            var data2 = new SupplierProduct { SupplierId =1, ProductId = 3};
            var data3 = new SupplierProduct { SupplierId =2, ProductId =3};
            var data4 = new SupplierProduct { SupplierId =4, ProductId = 5};
            var data5 = new SupplierProduct { SupplierId =3, ProductId =1};

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }
        public static void AddOrder()
        {
            var data1 = new Order { };
            var data2 = new Order { };
            var data3 = new Order { };
            var data4 = new Order { };
            var data5 = new Order { };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }
  
        public static void AddProductHistory()
        {
            var data1 = new ProductHistory { ProductId=1,Quantity=300,OrderDate= new DateTime(2000,02,10),SupplyDate=new DateTime(3032,02,01)};
            var data2 = new ProductHistory { ProductId = 2, Quantity = 300, OrderDate = new DateTime(2000, 02, 10), SupplyDate = new DateTime(2001,03, 11) };
            var data3 = new ProductHistory { ProductId = 3, Quantity = 40, OrderDate = new DateTime(2200, 12, 10), SupplyDate = new DateTime(2300, 03, 11) };
            var data4 = new ProductHistory { ProductId = 4, Quantity = 200, OrderDate = new DateTime(1992,04, 10), SupplyDate = new DateTime(2005,03, 11) };
            var data5 = new ProductHistory { ProductId = 5, Quantity = 3000, OrderDate = new DateTime(1998,03, 11), SupplyDate = new DateTime(2007, 03, 11) };

            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }
    }
}
