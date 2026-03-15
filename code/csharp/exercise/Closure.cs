using System;

namespace Closure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = "Hello";
            var action = new Func<string>(() => s + " world");

            s += "!";
            action();

            Console.WriteLine(s); //Hello!
        }
    }
}
