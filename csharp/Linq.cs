using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ids = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}.AsQueryable();
            var a = new[]
            {
                new A {X = 2},
                new A {X = 3},
                new A {X = 4},
            };

            var b = M(ids, a);

            foreach (var element in b)
            {
                Console.Write(element.Y ?? '*');
            }
        }

        private static IEnumerable<B> M(IQueryable<int> list, A[] a)
        {
            return list
                .Select(i => new
                {
                    v = (int?) a.FirstOrDefault(e => e.X == i).X
                })
                .Select(i => new B
                {
                    Y = i.v == null ? 0 : i.v
                })
                .ToList();
        }
    }

    public class A
    {
        public int X { get; set; }
    }

    public class B
    {
        public int? Y { get; set; }
    }
}

/*
Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
   at lambda_method(Closure , Int32 )
   at System.Linq.Utilities.<>c__DisplayClass2_0`3.<CombineSelectors>b__0(TSource x)
   at System.Linq.Enumerable.SelectArrayIterator`2.MoveNext()
   at System.Collections.Generic.List`1.AddEnumerable(IEnumerable`1 enumerable)
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at Linq.Program.M(IQueryable`1 list, A[] a) in Program.cs:line 29
   at Linq.Program.Main(String[] args) in Program.cs:line 19
*/
