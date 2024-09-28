namespace DecoratorPattern
{
    internal class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
