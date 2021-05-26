using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InsertData.AddDepartment();
            //InsertData.AddStaff();
            //InsertData.AddAddress();
            //InsertData.AddProduct();
            //InsertData.AddCategory();
            //InsertData.AddProductCategory();
            //InsertData.AddInventory();
            Console.WriteLine("inserted");

            CreateHostBuilder(args).Build().Run();

           
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
