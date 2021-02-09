using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.CustomAttributes
{
    public class Info : Attribute
    {
        private string description;

        public int Importance { get; set; }

        public Info(string description)
        {
            this.description = description;
        }
    }
}
