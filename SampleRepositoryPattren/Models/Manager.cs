using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepositoryPattren.Models
{
   public class Manager :Employee
    {

        public override void DoWork()
        {
            Console.WriteLine("Create work");
        }

    }
}
