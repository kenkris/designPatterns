using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton demo (main)");

            // TEST 1
            Console.WriteLine("------------- TEST 1 ------------");
            var firstSingleton = Singleton.GetInstance;

            Console.WriteLine("Do second instance of Singleton");

            var secondSingleton = Singleton.GetInstance;

            if(firstSingleton.Equals(secondSingleton))
                Console.WriteLine("Same instance returned");
            else
                Console.WriteLine("Different instance exists");

            // TEST 2
            Console.WriteLine("------------- TEST 2 ------------");

            var firstSingleton2 = Singleton2.GetInstance;

            var secondSingleton2 = Singleton2.GetInstance;

            if(firstSingleton2.Equals(secondSingleton2))
                Console.WriteLine("Same instance returned");
            else
                Console.WriteLine("Different instance exists");

        }
    }
}
