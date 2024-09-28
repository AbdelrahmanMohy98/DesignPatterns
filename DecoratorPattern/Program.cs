namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription() + " $" + espresso.Cost());

            Beverage darkRoast = new DarkRoast();
            Console.WriteLine(darkRoast.GetDescription() + " $" + darkRoast.Cost());


            Beverage houseBlend = new HouseBlend();
            Console.WriteLine(houseBlend.GetDescription() + " $" + houseBlend.Cost());

            houseBlend = new Milk(houseBlend);
            Console.WriteLine(houseBlend.GetDescription() + " $" + houseBlend.Cost());
            
            houseBlend = new Mocha(houseBlend);
            Console.WriteLine(houseBlend.GetDescription() + " $" + houseBlend.Cost());
            
            houseBlend = new Soy(houseBlend);
            Console.WriteLine(houseBlend.GetDescription() + " $" + houseBlend.Cost());

            Console.ReadKey();
        }
    }
}
