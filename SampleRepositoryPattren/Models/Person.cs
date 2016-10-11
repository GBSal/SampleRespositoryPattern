using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepositoryPattren.Models
{

   public interface IEntity {

        bool IsValid();
    }

    public class Person
    {

        public int Id { get; set; }

        public string Name { get; set; }

    }
}
