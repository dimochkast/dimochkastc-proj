

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Калькулятор скидочек");
        Console.WriteLine("Enter order value");
        decimal orderValue = Convert.ToDecimal(Console.ReadLine());
        decimal Discount = 0m;
        switch (orderValue)
        {
            case decimal n when n < 1000:
                break;
            case decimal n when n < 2500:
                Discount = 0.05m;
                break;
            case decimal n when n < 5000:
                Discount = 0.1m;
                break;
            case decimal n when n < 10000:
                Discount = 0.15m;
                break;
            case decimal n when n >= 10000:
                Discount = 0.2m;
                break;

        }
        Console.WriteLine($"Discounted price is {orderValue - orderValue * Discount}");
    }
}