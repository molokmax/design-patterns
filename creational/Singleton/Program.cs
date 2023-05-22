namespace Singleton;

internal class Program
{
    static void Main()
    {
        var cache1 = Cache.Instance;
        cache1.Save(1, "value 1");
        cache1.Save(2, "value 2");

        var cache2 = Cache.Instance;
        var val1 = cache2.Get(1);
        var val2 = cache2.Get(2);
        Console.WriteLine($"Values ['{val1}', '{val2}'] were retrieved");
    }
}
