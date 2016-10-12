using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleRepositoryPattren.Models
{
    public class Employee : Person , IEntity
    {

        public int Id { get; set; }
        

        public bool IsValid()
        {
            return true;
        }


        public virtual void DoWork()
        {

            Console.WriteLine("do some work");
        }
    }


}
