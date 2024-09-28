namespace DecoratorPattern
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 60;
        }
    }
}
