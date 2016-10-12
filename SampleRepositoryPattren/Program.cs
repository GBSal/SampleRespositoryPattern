using System;
using SampleRepositoryPattren.Models;
using SampleRepositoryPattren.Repositories;
using System.Linq;
using System.Data.Entity;


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
                CountEmployee(emp);
                FindEmployee(emp);

            }



            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }

        private static void FindEmployee(IRepository<Employee> emp)
        {
            var employee = emp.FindById(1);

            Console.WriteLine(employee.Name );
        }

        private static void CountEmployee(IRepository<Employee> emp)
        {
            Console.WriteLine(emp.FindAll().Count());
        }

        private static void AddEmployee(IRepository<Employee> emp)
        {
            emp.Add(new Employee { Name = "John", EmpNo = "112" });
            emp.Add(new Employee { Name = "Fox", EmpNo = "113" });

            emp.Commit();
        }
    }
}
