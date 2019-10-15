using Acelera.OO.Examples.Modifiers;
using System;

namespace Acelera.OO.Examples.II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void ProtectedPropertiesExample()
        {
            var protectedProperty = new ProtectedProperties();

            //protectedProperty.ProtectedId = 65; // protected property
            //protectedProperty.PrivateName = "New name"; // private property
            protectedProperty.PublicValue = 150; // public property
            //protectedProperty.InternalGuid = Guid.NewGuid(); // internal property
        }

        public void InternalClassExample()
        {
            //var internalClass = new InternalClass();
        }
    }
}
