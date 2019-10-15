using Acelera.OO.Examples.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Coupling
{
    public class PayrollExportPosStage : IPayrollExportStage
    {
        public void Execute(Payroll payroll, byte[] fileContent = null)
        {
            // Does some pre-process...
        }
    }
}
