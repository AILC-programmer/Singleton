using static System.Console;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singleton = SingletonClass.Instance;

            singleton.intValue = 23;
            singleton.strValue = "Arman Sadeghi";

            WriteLine($"Integer value of first instance: {singleton.intValue}");
            WriteLine($"String value of first instance:  {singleton.strValue}");

            SingletonClass singleton2 = SingletonClass.Instance;

            WriteLine($"Integer value of second instance: {singleton2.intValue}");
            WriteLine($"String value of second instance:  {singleton2.strValue}");
        }
    }
}
