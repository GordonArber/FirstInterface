using System;

namespace FirstInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(0);
            
            Console.WriteLine("How much fuel do you want to add to your car?");
            if (car.Refuel(Convert.ToInt32(Console.ReadLine())))
            {
                car.Drive();
            }
        }
    }
}