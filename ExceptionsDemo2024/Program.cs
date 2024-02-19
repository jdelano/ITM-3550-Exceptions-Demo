namespace ExceptionsDemo2024;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int num = int.Parse("TEST");
            ProductRepository repository = new();
            List<Product> products = repository.SearchByPriceRange(1000.0, 100.0);
            products.ForEach(product => Console.WriteLine($"{product.Name} - ${product.Price}"));
        }
        catch (InvalidPriceRangeException exception)
        {
            Console.WriteLine($"ERROR: {exception.Message}.");
        }
        catch (FormatException exception)
        {
            Console.WriteLine($"Buggy code: {exception.Message}");
        }

    }
}

