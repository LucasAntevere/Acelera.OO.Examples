using Acelera.OO.Examples.Interface;

namespace Acelera.OO.Examples.Coupling
{
    public interface IPayrollExportStage
    {
        void Execute(Payroll payroll, byte[] fileContent = null);
    }
}
