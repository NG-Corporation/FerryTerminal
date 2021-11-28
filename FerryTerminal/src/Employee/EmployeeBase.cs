using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.Employee
{
    public abstract class EmployeeBase : IEmployeeIncomeManager
    {
        public double SalaryIncome { get; set; }

        public EmployeeBase()
        {
            this.SalaryIncome = 0;
        }

        public void DisplaySalaryIncome()
        {
            Console.WriteLine($"Employee salary income : {SalaryIncome}");
        }

        public abstract void CalculateSalaryIncome(VehicleBase vehicle);
    }
}
