using DepartmentalStore.OperationOnDatabase;
using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore
{
    public class UserInputForQuery
    {
        public static StoreContext context = new StoreContext();
        
        public static void QueryOnStaff()
        {
            Console.WriteLine("Select Query type(1,2) :1)StaffByDepartment\n \t2)StaffDetails");
            var userChoice = Console.ReadLine();
            
            if (userChoice == "1") { StaffOperation.StaffByDepartment(); }
            if (userChoice == "2") { StaffOperation.StaffDetails(); }
        }

        public static void QueryOnProduct()
        {

            Console.WriteLine("Select Query type(1,2,3,4,5,6) : 1)ProductOutOfStock\n \t 2)ProductInStock\n \t 3)ProductWithinCategory\n \t4)ProductByName\n \t5)ProductByPrice\n \t6)ProductByName");
            var userChoice = Console.ReadLine();

            if (userChoice == "1") { ProductOperation.ProductOutOfStock(); }
            if (userChoice == "2") { ProductOperation.ProductInStock(); }
            if (userChoice == "3") { ProductOperation.ProductWithinCategory(); }
            if (userChoice == "4") { ProductOperation.ProductByName(); }
            if (userChoice == "5") { ProductOperation.ProductByPrice(); }

        }


        public static void QueryOnSupplier()
        {
            SupplierOperation.SupplierDetails();
        }

        public static void QueryOnOrder()
        {
            Console.WriteLine("Select Query type(1,2,3) : 1)BySupplierName\n \t 2)SupplyAfterParticularDate\n \t 3)SupplyBeforeParticularDate");
            var userChoice = Console.ReadLine();

            if (userChoice == "1") {OrderSupplyOperation.BySupplierName(); }
            if (userChoice == "2") { OrderSupplyOperation.SupplyAfterParticularDate(); }
            if (userChoice == "3") { OrderSupplyOperation.SupplyBeforeParticularDate(); }
         
        }




    }
}
