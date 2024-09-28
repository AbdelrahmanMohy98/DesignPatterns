namespace DecoratorPattern
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage { get; set; }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }
}
