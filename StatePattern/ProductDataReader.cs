namespace StatePattern
{
    public class ProductDataReader
    {
        public IEnumerable<Product> GetProducts()
        {
            return new[]
            {
                new Product{ Id = 1, Name = "Monitor", UnitPrice = 2800},
                new Product{ Id = 2, Name = "Printer", UnitPrice = 70000},
                new Product{ Id = 3, Name = "Laptop", UnitPrice = 18000},
                new Product{ Id = 4, Name = "Keyboard", UnitPrice = 750},
                new Product{ Id = 5, Name = "Mouse", UnitPrice = 300}
            };
        }
    }
}
