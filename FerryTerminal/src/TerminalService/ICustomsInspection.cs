using FerryTerminal.src.Vehicle;

namespace FerryTerminal.src.TerminalService
{
    public interface ICustomsInspection
    {
        public void OpenCargoForInspection(VehicleBase vehicle);
    }
}
