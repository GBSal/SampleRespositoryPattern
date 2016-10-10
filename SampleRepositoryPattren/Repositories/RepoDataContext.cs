using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using SampleRepositoryPattren.Models;


namespace SampleRepositoryPattren.Repositories
{
    public class RepoDataContext:DbContext
    {

        public RepoDataContext()
        {

        }



        public DbSet<Person> Persons { get; set; }

        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<Manager> Managers { get; set; }
    }
}
