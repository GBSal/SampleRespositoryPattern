using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleRepositoryPattren.Models
{
    public class Employee : Person , IEntity
    {
        


        public string  EmpNo { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
