using Store.Data;
using Store.Domain;
using System;

namespace DepartmentalStore
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert Data");

            //InsertData.AddDepartment();
            //InsertData.AddStaff();
            //InsertData.AddAddress();
            //InsertData.AddProduct();
            //InsertData.AddCategory();
            //InsertData.AddProductCategory();
            //InsertData.AddInventory();
            //InsertData.AddSupplier();
            //InsertData.AddSupplierProduct();
            ////InsertData.AddOrder();
            //InsertData.AddProductHistory();


            Console.WriteLine("Select Query type(1,2,3) :\n \t 1)Query on product \n \t 2)Query on staff \n \t 3)Query on Supplier\n  ");
            var userChoice = Console.ReadLine();
            if (userChoice == "1") { Query.QueryOnProduct(); }
            if (userChoice == "2") { Query.QueryOnStaff();   }
            if (userChoice == "3") { Query.QueryOnSupplier(); }


        }

    }
}
