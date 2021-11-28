using FerryTerminal.src.Employee;
using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.Terminal
{
    public abstract class TerminalBase : ITerminalTrack
    {
        public double TerminalIncome { get; set; }

        public TerminalBase()
        {
            this.TerminalIncome = 0;
        }

        public void DisplayTerminalIncome()
        {
            Console.WriteLine($"Terminal income : {TerminalIncome}");
        }

        public abstract void TrackArrivalVehicle(VehicleBase vehicle);
    }
}
