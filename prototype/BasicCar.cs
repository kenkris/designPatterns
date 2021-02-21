using System;

namespace prototype
{
    public abstract class BasicCar
    {
        public int BasePrice;
        public int OnRoadPrice;
        public string ModelName { get; set; }

        public static int SetAdditionalPrice()
        {
            var random = new Random();
            return random.Next(25000, 75000);
        }

        public abstract BasicCar Clone();
    }
}