namespace singleton
{
    public sealed class Singleton2
    {
        private static readonly Singleton2 Instance = new Singleton2();

        private Singleton2() { }

        public static Singleton2 GetInstance => Instance;
    }
}