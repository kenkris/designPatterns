using System;

namespace singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance;
        private static int NoOfInstance;
        public static Singleton GetInstance => Instance;
        public static int SomeInt = 25;

        // Private constructor makes sure that new Singleton cant be called out side this class
        private Singleton()
        {
            Console.WriteLine("Private singleton constructor called");
        }

        // Actions to be done only once
        static Singleton()
        {
            Console.WriteLine("Static constructor called");
            Instance = new Singleton();
            NoOfInstance ++;
            Console.WriteLine($"No of instance created {NoOfInstance}");
        }


    }
}