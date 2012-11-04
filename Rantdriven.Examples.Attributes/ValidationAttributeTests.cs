using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Rantdriven.Examples.Attributes
{
    [TestFixture]
    public class ValidationAttributeTests
    {
        [Test]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestValidation()
        {
            var type = typeof (Person);
            var email = type.GetProperties().First(x => x.GetCustomAttributes(false).Any());
            var attribute = email.GetCustomAttributes(true).First(x=>x.GetType()==typeof(ValidationAttribute));
            Assert.AreEqual(attribute.GetType(), typeof(ValidationAttribute));

            var validate = attribute as ValidationAttribute;
            validate.Validate();
        }
    }
}
