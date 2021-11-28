using System;

namespace FerryTerminal.src.Vehicle
{
    public class Van : VehicleBase
    {
        public Van(int ticketPrice, int gasAmount) : base(ticketPrice, gasAmount)
        {
        }

        public override void DisplayTicketPrice()
        {
            Console.WriteLine($"Van ticket price : {TicketPrice}");
        }

        public override void DisplayGasAmount()
        {
            Console.WriteLine($"Van gas amount : {GasAmount}");
        }

        public override bool IsCargoVehicle()
        {
            return true;
        }

        public override bool IsSmallVehicle()
        {
            return true;
        }
    }
}
