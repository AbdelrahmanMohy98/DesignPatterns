namespace FactoryMethod2
{
    abstract class Payment
    {
        public Decimal calcDiscound(decimal amount)
        {
            return amount;
        }
    }
}
