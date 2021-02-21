namespace prototype
{
    public class CarFactory
    {
        private readonly BasicCar _ford;
        private readonly BasicCar _vw;

        public CarFactory()
        {
            _ford = new Ford("Mondeo");
            _vw = new Vw("Pasat");
        }

        public BasicCar GetFord()
        {
            return _ford.Clone();
        }

        public BasicCar GetVw()
        {
            return _vw.Clone();
        }
    }
}