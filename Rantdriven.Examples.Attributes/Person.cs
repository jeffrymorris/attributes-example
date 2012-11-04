using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rantdriven.Examples.Attributes
{
    public class Person
    {
        [Validation(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}")]
        public string Email { get; set; }
    }
}
