using System;

namespace FerryTerminal.src.Vehicle
{
    public class Car : VehicleBase
    {
        public Car(int ticketPrice, int gasAmount) : base(ticketPrice, gasAmount)
        {
        }

        public override void DisplayTicketPrice()
        {
            Console.WriteLine($"Car ticket price : {TicketPrice}");
        }

        public override void DisplayGasAmount()
        {
            Console.WriteLine($"Car gas amount : {GasAmount}" );
        }

        public override bool IsCargoVehicle()
        {
            return false;
        }

        public override bool IsSmallVehicle()
        {
            return true;
        }
    }
}
