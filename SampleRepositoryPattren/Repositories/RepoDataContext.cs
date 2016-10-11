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

        public DbSet<Employee> Employees { get; set; }
        
    }




    interface IRepository<T> :IDisposable
    {
        void Add(T entity);

        void Delete(int Id);

        IQueryable<T> FindAll();

        T FindById(int Id);


        int Commit();

        

    }


    public class SqlRepository<T> : IRepository<T> where T :class , IEntity // T is class and its a IEntity.
    {
        DbContext _ctx;
        DbSet<T> _set;
        public SqlRepository(DbContext ctx)
        {
            _ctx = ctx;
            _set = _ctx.Set<T>();
        }

        public void Add(T entity)
        {

            if (entity.IsValid())
                _set.Add(entity);
        }

        public int Commit()
        {
            return _ctx.SaveChanges();
        }

        public void Delete(int Id)
        {
            
        }

        public IQueryable<T> FindAll()
        {
            return _set;   
        }

        public T FindById(int Id)
        {
            return _set.Find(Id);
        }


        public void Dispose()
        {
            _ctx.Dispose();
        }

    }




}
