using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.Gas
{
    public class GasStation : IGasStation
    {
        public void CheckGasAmount(VehicleBase vehicle)
        {
            vehicle.DisplayGasAmount();
            if (vehicle.GasAmount < 10)
            {
                Console.WriteLine($"Vehicle is in gas station (G)");
            }
        }
    }
}
