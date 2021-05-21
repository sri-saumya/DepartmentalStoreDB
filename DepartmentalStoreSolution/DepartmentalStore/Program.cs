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

            while (true)
            {

                Console.WriteLine("Select Query type(1,2,3) :1)Query on staff\n \t2)Query on product \n \t3)Query on Supplier");
                var userChoice = Console.ReadLine();
                if (userChoice == "2") { Query.QueryOnProduct(); }
                if (userChoice == "1") { Query.QueryOnStaff(); }
                if (userChoice == "3") { Query.QueryOnSupplier(); }
                  

            }

        }

    }
}
