using System;

namespace FirstInterface
{
    public class Car: IVehiculo
    {
        int AmountOfGas { get; set; }

        public Car(int startingGasoline)
        {
            AmountOfGas = startingGasoline;
        }

        public void Drive()
        {
            Console.WriteLine(AmountOfGas > 0 ? "Driving" : "Not enough fuel to drive.");
        }

        public bool Refuel(int amountOfGas)
        {
            AmountOfGas += amountOfGas;
            return true;
        }
    }
}