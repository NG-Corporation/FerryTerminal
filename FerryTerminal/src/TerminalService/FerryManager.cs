using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.TerminalService
{
    public class FerryManager : IFerryManager
    {
        public void ChooseFerryKind(VehicleBase vehicle)
        {
            if (vehicle.IsSmallVehicle())
            {
                Console.WriteLine("Vehicle is in small ferry (S)");
            }
            else
            {
                Console.WriteLine("Vehicle is in large ferry (L)");
            }
        }
    }
}
