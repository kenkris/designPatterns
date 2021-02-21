namespace prototype
{
    public class Vw : BasicCar
    {

        public Vw(string modelName){
            ModelName = modelName;
            BasePrice = 450000;
        }
        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Vw;
        }
    }
}