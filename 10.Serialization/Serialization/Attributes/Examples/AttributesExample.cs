using Attributes.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Examples
{
    [Info("This is attributes example class", Importance = 42)]
    public class AttributesExample
    {
        [Info("This is field")]
        private int quantity;

        [Info("This is property")]
        public double Sum { get ; set; }

        [Info("This is method")]
        public double ShowResult()
        {
            return Sum * quantity;
        }
    }
}