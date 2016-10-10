using System;
using SampleRepositoryPattren.Models;
using SampleRepositoryPattren.Repositories;
using System.Linq;


namespace SampleRepositoryPattren
{
    public class Program
    {
        static void Main(string[] args)
        {



            var db = new RepoDataContext();

            db.Employees.Add(new Employee { Id = 1, EmpName = "IT Sam" });

            db.SaveChanges();

            Console.WriteLine(db.Employees.Count());


            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
