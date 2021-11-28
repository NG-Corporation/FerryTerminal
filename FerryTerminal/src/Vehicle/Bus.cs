using System;

namespace FerryTerminal.src.Vehicle
{
    public class Bus : VehicleBase
    {
        public Bus(int ticketPrice, int gasAmount) : base(ticketPrice, gasAmount)
        {
        }

        public override void DisplayTicketPrice()
        {
            Console.WriteLine($"Bus ticket price : {TicketPrice}");
        }

        public override void DisplayGasAmount()
        {
            Console.WriteLine($"Bus gas amount : {GasAmount}" );
        }

        public override bool IsCargoVehicle()
        {
            return false;
        }

        public override bool IsSmallVehicle()
        {
            return false;
        }
    }
}
