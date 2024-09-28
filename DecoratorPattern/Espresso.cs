namespace DecoratorPattern
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";    
        }

        public override double Cost()
        {
            return 70;
        }
    }
}
