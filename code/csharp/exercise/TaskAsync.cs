using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = null;
            string str = args.Length > 0 ? args[0] : null;
            try
            {
                Log("before async action", nameof(Main));
                task = ActionAsync(str);
                Log("after async action", nameof(Main));
            }
            catch (Exception)
            {
                Log("catch", nameof(Main));
            }
            finally
            {
                Log("finally", nameof(Main));
            }

            task?.Wait();
        }

        private static async Task<int> ActionAsync(string s)
        {
            Log("before await", nameof(ActionAsync));
            int length = await Action(s);
            Log("after await", nameof(ActionAsync));
            return length;
        }

        private static Task<int> Action(string s)
        {
            return Task.Factory.StartNew(() => {
                Log(s?.Length.ToString() ?? "null", "Lambda");
                return s.Length;
            });
        }

        private static void Log(string message, string methodName)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {methodName}: {message}");
        }
    }
}

/*
    dotnet run abc
    Thread 1: Main: before async action
    Thread 1: ActionAsync: before await
    Thread 4: Lambda: 3
    Thread 1: Main: after async action
    Thread 1: Main: finally
    Thread 4: ActionAsync: after await

    dotnet run
    Thread 1: Main: before async action
    Thread 1: ActionAsync: before await
    Thread 4: Lambda: null
    Thread 1: Main: after async action
    Thread 1: Main: finally
    Unhandled exception. System.AggregateException: One or more errors occurred. (Object reference not set to an instance of an object.)
*/
