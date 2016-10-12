using System;
using SampleRepositoryPattren.Models;
using SampleRepositoryPattren.Repositories;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace SampleRepositoryPattren
{
    public class Program
    {
        static void Main(string[] args)
        {

            Database.SetInitializer(new DropCreateDatabaseAlways<RepoDataContext>());

            using (IRepository<Employee> emp =
                new SqlRepository<Employee>(new RepoDataContext()))
            {

                AddEmployee(emp);
                AddManager(emp);

                CountEmployee(emp);
                FindEmployee(emp);


            }



            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }

        private static void AddManager(IWriteOnlyRepository<Manager> emp)
        {
            emp.Add(new Manager { Name = "Russell" });
            emp.Commit();
         
        }

        private static void FindEmployee(IReadOnlyRepository<Person> emp)
        {
            var employee = emp.FindAll();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Name);

            }


        }

        private static void CountEmployee(IRepository<Employee> emp)
        {
            Console.WriteLine(emp.FindAll().Count());
        }

        private static void AddEmployee(IRepository<Employee> emp)
        {
            emp.Add(new Employee { Name = "Saima Salman"});
            emp.Add(new Employee { Name = "Mohammad Salman"});

            emp.Commit();
        }
    }
}
