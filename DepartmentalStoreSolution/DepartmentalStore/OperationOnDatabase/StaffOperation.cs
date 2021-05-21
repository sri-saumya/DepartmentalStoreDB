using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentalStore.OperationOnDatabase
{
    public class StaffOperation
    {
        public static StoreContext context = new StoreContext();

        public static void StaffDetails()
        {
            Console.WriteLine("Query1 : Query Staff using name or phone number or both ");
            List<Staff> queryname = context.Staff.Where(s => s.FirstName.ToLower() == "mark" || s.PhoneNumber == "3453389234").ToList();
            Console.WriteLine("FirstName" + "\t" + "LastName" + "\t\t" + "Salary" + "\t" + "Phone Number\n");
            queryname.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName} \t\t {i.LastName}\t\t {i.Salary} \t\t{i.PhoneNumber}");
            });
        }

        public static void StaffByDepartment()
        {
            Console.WriteLine("Query2 : Query on Staff - using Department");
            var res = context.Staff.Join(context.Department,
                             e1 => e1.Id,
                             e3 => e3.Id,
                             (e1, e3) => new {
                                 prod = e1.FirstName,
                                 cat = e3.DepartmentName
                             });
            Console.WriteLine("Name" + "\t\t" + "DepartmentName \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{i.prod} \t\t {i.cat}");
            }
        }
    }
}
