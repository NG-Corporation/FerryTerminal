using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.Gas
{
    public interface IGasStation
    {
        public void CheckGasAmount(VehicleBase vehicle);
    }
}
