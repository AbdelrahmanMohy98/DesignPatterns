﻿namespace DecoratorPattern
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast() 
        {
            description = "Dark Roast";
        }
        
        public override double Cost()
        {
            return 50;
        }
    }
}
