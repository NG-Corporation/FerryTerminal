using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.TerminalService
{
    public interface IFerryManager
    {
        public void ChooseFerryKind(VehicleBase vehicle);
    }
}
