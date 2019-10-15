using Acelera.OO.Examples.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Coupling
{
    public abstract class PayrollExportAbstractBase : IPayrollExport
    {
        private readonly IPayrollExportStage _preStage;
        private readonly IPayrollExportStage _posStage;

        public PayrollExportAbstractBase(IPayrollExportStage preStage, 
                                         IPayrollExportStage posStage)
        {
            _preStage = preStage;
            _posStage = posStage;
        }

        public byte[] Export(Payroll payroll)
        {
            _preStage.Execute(payroll);

            var fileContent = CreateFileToExport(payroll);

            _posStage.Execute(payroll, fileContent);
            
            return fileContent;
        }
        
        protected abstract byte[] CreateFileToExport(Payroll payroll);
    }

    public class PayrollExportToPdf : PayrollExportAbstractBase
    {
        public PayrollExportToPdf() : base(new PayrollExportPreStage(),
                                           new PayrollExportPosStage())
        {

        }

        protected override byte[] CreateFileToExport(Payroll payroll)
        {
            // Create pdf file...
            return new byte[10];
        }
    }

    public class PayrollExportToCsv : PayrollExportAbstractBase
    {
        public PayrollExportToCsv() : base(new PayrollExportPreStage(),
                                           new PayrollExportPosStage())
        {

        }

        protected override byte[] CreateFileToExport(Payroll payroll)
        {
            // Create csv file...
            return new byte[10];
        }
    }
}
