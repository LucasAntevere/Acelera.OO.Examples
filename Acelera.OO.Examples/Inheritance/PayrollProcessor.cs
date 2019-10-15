using Acelera.OO.Examples.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Inheritance
{
    public class PayrollProcessor
    {
        public Payroll ProcessPayRollForEmployee(Employee ceo)
        {
            var bonus = ceo.GetBonus();
            // Process payroll

            return new Payroll();
        }

        public Payroll ProcessPayRollForManager(Manager ceo)
        {
            var bonus = ceo.GetBonus();
            // Process payroll

            return new Payroll();
        }

        public Payroll ProcessPayRollForCEO(CEO ceo)
        {
            var bonus = ceo.GetBonus();
            // Process payroll

            return new Payroll();
        }
    }
}
