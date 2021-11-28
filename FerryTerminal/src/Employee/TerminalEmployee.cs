using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.Employee
{
    public class TerminalEmployee : EmployeeBase
    {
        public TerminalEmployee()
        {
        }

        public override void CalculateSalaryIncome(VehicleBase vehicle)
        {
            this.SalaryIncome += vehicle.TicketPrice * 0.1;
        }
    }
}
