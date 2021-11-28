using System;

namespace FerryTerminal.src.Vehicle
{
    public class Truck : VehicleBase
    {
        public Truck(int ticketPrice, int gasAmount) : base(ticketPrice, gasAmount)
        {
        }

        public override void DisplayTicketPrice()
        {
            Console.WriteLine($"Truck ticket price : {TicketPrice}");
        }

        public override void DisplayGasAmount()
        {
            Console.WriteLine($"Truck gas amount : {GasAmount}");
        }

        public override bool IsCargoVehicle()
        {
            return true;
        }

        public override bool IsSmallVehicle()
        {
            return false;
        }
    }
}
