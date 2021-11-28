using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal.src.Terminal
{
    public class TerminalHandlerService : ITerminalHandlerService
    {
        private TerminalBase FerryTerminal;

        public TerminalHandlerService() {
            this.FerryTerminal = new FerryTerminal();
        }

        public void ArrivingVehicleHandler(VehicleBase vehicle)
        {
            vehicle.DisplayTicketPrice();

            this.FerryTerminal.TrackArrivalVehicle(vehicle);

            Console.WriteLine();
            this.FerryTerminal.DisplayTerminalIncome();
        }
    }
}
