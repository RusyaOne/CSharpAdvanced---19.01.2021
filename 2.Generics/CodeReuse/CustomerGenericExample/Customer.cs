using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReuse.CustomerGenericExample
{
    public class Customer<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public T Address { get; set; }
    }
}
