using StatePattern;

var products = new ProductDataReader().GetProducts();

while (true)
{
    foreach (var product in products)
    {
        Console.WriteLine(product.Id + "- " + product.Name + " (" + product.UnitPrice +") ");
    }
    Console.WriteLine();

    Order order = new Order();

    while (true)
    {
        Console.WriteLine("Select Product ID.");
        int productId = int.Parse(Console.ReadLine());

        if (productId == 0) {
            Console.WriteLine("Your Order IS: ");
            foreach (var line in order.OrderLines)
            {
                string productName = products.FirstOrDefault(a => a.Id == line.ProductId).Name;
                Console.WriteLine(productName + "- " + line.Quantity + " (" + line.UnitPrice + ") ");
            }
            Console.WriteLine();
            break;
        }

        Console.Write("Enter Product Quantity: ");
        int productQuantity = int.Parse(Console.ReadLine());

        Product product = products.FirstOrDefault(a => a.Id == productId);
        OrderLine orderLine = order.OrderLines.FirstOrDefault(a => a.ProductId == product.Id);

        if (orderLine != null)
        {
            orderLine.UnitPrice += productQuantity * product.UnitPrice;
            orderLine.Quantity += productQuantity;
        }
        else
        {
            order.OrderLines.Add(new OrderLine() { ProductId = productId, UnitPrice = product.UnitPrice * productQuantity, Quantity = productQuantity });
        }

    }

    while (true)
    {
        Console.WriteLine("Select Action");
        Console.WriteLine("\t1. Confirm \n\t2. Process \n\t3. Cancel  \n\t4. Ship  \n\t5. Deliver \n\t6. Return \n\t0. Exit");

        var action = int.Parse(Console.ReadLine());

        try
        {
            switch (action)
            {
                case 0: break;
                case 1: order.Confirm(); break;
                case 2: order.Process(); break;
                case 3: order.Cancel(); break;
                case 4: order.Ship(); break;
                case 5: order.Deliver(); break;
                case 6: order.Return(); break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order state changed to: {order.State}");
            Console.ForegroundColor = ConsoleColor.White;

        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}