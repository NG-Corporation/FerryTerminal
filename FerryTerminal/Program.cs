using FerryTerminal.src.Terminal;
using FerryTerminal.src.Vehicle;
using System;

namespace FerryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleGenerator vehicleGenerator = new VehicleGenerator();
            ITerminalHandlerService terminalHandlerService = new TerminalHandlerService();

            do
            {
                while (!Console.KeyAvailable)
                {
                    ConsoleKey pressedKey = Console.ReadKey(true).Key;
                    if (pressedKey == ConsoleKey.Enter)
                    {
                        terminalHandlerService.ArrivingVehicleHandler(vehicleGenerator.GetRadomVehicle());
                    }

                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
