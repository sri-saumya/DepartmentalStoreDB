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

                Console.WriteLine("Select Query type(1,2,3) :1)Query on staff\n \t2)Query on product \n \t3)Query on Supplier\n \t4)Query on Order and Supply");
                var userChoice = Console.ReadLine();
                if (userChoice == "1") { UserInputForQuery.QueryOnStaff(); }
                if (userChoice == "2") { UserInputForQuery.QueryOnProduct(); }
                if (userChoice == "3") { UserInputForQuery.QueryOnSupplier(); }
                if (userChoice == "4") { UserInputForQuery.QueryOnOrder(); }



            }

        }

    }
}
