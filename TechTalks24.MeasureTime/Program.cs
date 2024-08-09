using MethodTimer;
using System.Reflection;


namespace TechTalks24.MeasureTime;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order();
        order.CalculatePrice(10);
    }
}


public class Order
{
    [Time]
    public decimal CalculatePrice(int quantity)
    {
        Task.Delay(1000).Wait();

        return quantity * 10;
    }
}


public static class MethodTimeLogger
{
    public static void Log(MethodBase methodBase, TimeSpan timeSpan, string message)
    {
        Console.WriteLine($"{methodBase.DeclaringType!.Name}.{methodBase.Name}: {timeSpan}");
    }
}
