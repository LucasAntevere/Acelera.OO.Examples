using Acelera.OO.Examples.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Cohesion
{
    public abstract class PayrollExportAbstractBase : IPayrollExport
    {
        public byte[] Export(Payroll payroll)
        {
            //PreProcess(payroll);
            var preProcessor = new PayrollPreProcessor();
            preProcessor.PreProcess(payroll);

            var fileContent = CreateFileToExport(payroll);

            //PosProcess(payroll, fileContent);
            var posProcessor = new PayrollPosProcessor();
            posProcessor.PosProcess(payroll, fileContent);
            
            return fileContent;
        }

        //private void PreProcess(Payroll payroll)
        //{
        //    // Does some pre-process...
        //}

        //private void PosProcess(Payroll payroll, byte[] fileContent)
        //{
        //    // Does some pos-process...
        //}

        protected abstract byte[] CreateFileToExport(Payroll payroll);
    }

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
