using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    private static volatile bool complete = false;

    static void Main(string[] args)
    {
        TestAsync();
        Console.ReadKey(true);
    }

    private static async void TestAsync()
    {
        Func<Task> testFunc = async () =>
        {
            await Task.Delay(1000);
            bool toggle = false;
            while (!complete) toggle = !toggle;
        };

        var task = testFunc();
        Thread.Sleep(2000);
        complete = true;
        await task;
        Console.WriteLine("Done");
    }
}