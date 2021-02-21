using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();

            var ford = carFactory.GetFord();
            ford.OnRoadPrice = ford.BasePrice + BasicCar.SetAdditionalPrice();
            var vw = carFactory.GetVw();
            vw.OnRoadPrice = vw.BasePrice + BasicCar.SetAdditionalPrice();

            // Print cloned objects
            Console.WriteLine($"{ford.ModelName} - {ford.OnRoadPrice}");
            Console.WriteLine($"{vw.ModelName} - {vw.OnRoadPrice}");
        }
    }
}
