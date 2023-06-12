using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredExecution
{
    public class Item
    {
        public static int Instances { get; set; } = 0;
        
        public int Value { get; set; }
        
        public Item(int v)
        {
            Value = v;
            Instances++;
        }
    }

    public class Program
    {
        private static IEnumerable<int> GetCounter(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return i;
            }
        }
      
        public static void Main()
        {
            var counter = GetCounter(10);
            var items = counter.Select(n => new Item(n));
            Console.WriteLine(Item.Instances); // 0

            var itemsList = new List<Item>();
            itemsList.AddRange(items);
            Console.WriteLine(Item.Instances); // 10
            
            var count = items.Where(e => e.Value < 5).Count();
            Console.WriteLine(Item.Instances); // 20
        }   
    }
}