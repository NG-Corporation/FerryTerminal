using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.Employee
{
    public interface IEmployeeIncomeManager
    {
        public void CalculateSalaryIncome(VehicleBase vehicle);
        
    }
}
