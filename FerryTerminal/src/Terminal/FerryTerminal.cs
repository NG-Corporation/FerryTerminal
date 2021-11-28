using FerryTerminal.src.Employee;
using FerryTerminal.src.Gas;
using FerryTerminal.src.TerminalService;
using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.Terminal
{
    public class FerryTerminal : TerminalBase
    {
        public EmployeeBase TerminalEmployee;
        public IGasStation GasStation;
        public ICustomsInspection CustomsInspection;
        public IFerryManager FerryManager;

        public FerryTerminal() {
            this.TerminalEmployee = new TerminalEmployee();
            this.GasStation = new GasStation();
            this.CustomsInspection = new CustomsInspection();
            this.FerryManager = new FerryManager();
        }

        public override void TrackArrivalVehicle(VehicleBase vehicle)
        {
            this.TerminalIncome += vehicle.TicketPrice;

            // caculate employee salary income
            Console.WriteLine();
            this.TerminalEmployee.CalculateSalaryIncome(vehicle);
            this.TerminalEmployee.DisplaySalaryIncome();

            // Gas station
            Console.WriteLine();
            this.GasStation.CheckGasAmount(vehicle);

            // Customs inspection
            Console.WriteLine();
            this.CustomsInspection.OpenCargoForInspection(vehicle);

            // Ferry manager
            Console.WriteLine();
            this.FerryManager.ChooseFerryKind(vehicle);
        }
    }
}
