namespace FerryTerminal.src.Vehicle
{
    public abstract class VehicleBase : IVehicleDisplay, IVehicleProperty
    {
        public int TicketPrice { get; set; }

        public int GasAmount { get; set; }

        public VehicleBase(int ticketPrice, int gasAmount)
        {
            this.TicketPrice = ticketPrice;
            this.GasAmount = gasAmount;
        }

        public abstract void DisplayTicketPrice();
        public abstract void DisplayGasAmount();
        public abstract bool IsCargoVehicle();
        public abstract bool IsSmallVehicle();
    }
}
