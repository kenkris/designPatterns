namespace prototype
{
    public class Ford : BasicCar
    {

        public Ford(string modelName){
            ModelName = modelName;
            BasePrice = 250000;
        }
        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }
}