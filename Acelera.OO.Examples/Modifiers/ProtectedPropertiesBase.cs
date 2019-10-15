using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Modifiers
{
    public class ProtectedPropertiesBase
    {   
        protected int ProtectedId { get; set; }
        private string PrivateName { get; set; }
        public decimal PublicValue { get; set; }
        internal Guid InternalGuid { get; set; }
    }

    public class ProtectedProperties : ProtectedPropertiesBase
    {
        public ProtectedProperties()
        {
            ProtectedId = 10;
            //Name = "Value";
            PublicValue = 150;
        }
    }
}
