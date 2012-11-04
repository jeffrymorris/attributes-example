using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rantdriven.Examples.Attributes
{
    public class ValidationAttribute : Attribute
    {
        private string _regex ;
        public ValidationAttribute(string regex)
        {
            _regex = regex;
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
