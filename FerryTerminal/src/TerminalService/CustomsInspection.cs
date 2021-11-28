using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.TerminalService
{
    public class CustomsInspection : ICustomsInspection
    {
        public void OpenCargoForInspection(VehicleBase vehicle)
        {
            if(vehicle.IsCargoVehicle())
            {
                Console.WriteLine("Cargo is open");
                Console.WriteLine("Vehicle is in customs inspection area (C)");
            }
        }
    }
}
