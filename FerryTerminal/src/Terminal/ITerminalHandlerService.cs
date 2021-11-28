using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.Terminal
{
    public interface ITerminalHandlerService
    {
        public void ArrivingVehicleHandler(VehicleBase vehicle);
    }
}
