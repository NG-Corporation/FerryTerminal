using System;
using System.Collections.Generic;

namespace FerryTerminal.src.Vehicle
{
    class VehicleGenerator : IVehicleGenerator
    {
        private List<VehicleBase> VehicleList = new List<VehicleBase> {
            new Car(3, 0),
            new Van(4, 0),
            new Bus(5, 0),
            new Truck(6, 0),
        };

        private Random Random = new Random();
        public VehicleBase GetRadomVehicle()
        {
            int gasAmount = Random.Next(0, 20);
            int index = Random.Next(0, 4);
            VehicleBase vehicle = this.VehicleList[index];
            vehicle.GasAmount = gasAmount;
            return vehicle;
        }
    }
}
