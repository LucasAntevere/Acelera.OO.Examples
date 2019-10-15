using Acelera.OO.Examples.Inheritance;
using Acelera.OO.Examples.Methods;
using Acelera.OO.Examples.Modifiers;
using System;

namespace Acelera.OO.Examples
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void ProtectedPropertiesExample()
        {
            var protectedProperty = new ProtectedProperties();

            //protectedProperty.ProtectedId = 65; // protected property
            //protectedProperty.PrivateName = "New name"; // private property
            protectedProperty.PublicValue = 150; // public property
            protectedProperty.InternalGuid = Guid.NewGuid(); // internal property
        }

        public void StaticMethodExample()
        {
            var applicationName = StaticExample.GetApplicationName();
            var applicationVersion = StaticExample.ApplicationVersion;
        }

        public void InheritanceExample()
        {
            var employee = new Employee(150);
            var manager = new Manager(200);
            var ceo = new CEO(300);

            var payrollProcessor = new PayrollProcessor();

            payrollProcessor.ProcessPayRollForEmployee(employee);
            payrollProcessor.ProcessPayRollForManager(manager);
            payrollProcessor.ProcessPayRollForCEO(ceo);
        }
    }
}