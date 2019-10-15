using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Interface
{
    public class Payroll
    {
        // attributes...
    }

    public interface IPayrollExport
    {
        byte[] Export(Payroll payroll);
    }

    // TODO: Create PDF and CSV export using the interface.

    public abstract class PayrollExportToPdf : IPayrollExport
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

        private byte[] CreateFileToExport(Payroll payroll)
        {
            // Create PDF file...

            return new byte[10];
        }
    }
}
