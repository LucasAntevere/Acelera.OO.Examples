using Acelera.OO.Examples.Inheritance;
using Acelera.OO.Examples.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.AbstractClass
{
    public abstract class PayrollExportAbstractBase : IPayrollExport
    {
        public byte[] Export(Payroll payroll)
        {
            PreProcess(payroll);

            var fileContent = CreateFileToExport(payroll);

            PosProcess(payroll, fileContent);

            return fileContent;
        }

        private void PreProcess(Payroll payroll)
        {
            // Does some pre-process...
        }

        private void PosProcess(Payroll payroll, byte[] fileContent)
        {
            // Does some pos-process...
        }

        protected abstract byte[] CreateFileToExport(Payroll payroll);
    }

    // TODO: Implement PDF and CVS export using abstract class.

    public class PayrollExportToPdf : PayrollExportAbstractBase
    {
        protected override byte[] CreateFileToExport(Payroll payroll)
        {
            // Create pdf file...
            return new byte[10];
        }
    }

    public class PayrollExportToCsv : PayrollExportAbstractBase
    {
        protected override byte[] CreateFileToExport(Payroll payroll)
        {
            // Create csv file...
            return new byte[10];
        }
    }
}
