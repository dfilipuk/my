# .NET & C# cheat sheet

## Overview

[.NET Architectural components](https://docs.microsoft.com/en-us/dotnet/standard/components)

[.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)

[.NET Common type system](https://docs.microsoft.com/en-us/dotnet/standard/base-types/common-type-system)

[C# major language areas](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/features)

## .NET execution model

[Common Language Runtime (CLR) overview](https://docs.microsoft.com/en-us/dotnet/standard/clr)

[Managed Execution Process](https://docs.microsoft.com/en-us/dotnet/standard/managed-execution-process)

[Assemblies in .NET](https://docs.microsoft.com/en-us/dotnet/standard/assembly/)

[Metadata and Self-Describing Components](https://docs.microsoft.com/en-us/dotnet/standard/metadata-and-self-describing-components)

## Memory management

[What is "managed code"?](https://docs.microsoft.com/en-us/dotnet/standard/managed-code)

[Automatic Memory Management](https://docs.microsoft.com/en-us/dotnet/standard/automatic-memory-management)

### Garbage Collection

[Fundamentals of garbage collection](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)

[The large object heap](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/large-object-heap)

[Background garbage collection](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/background-gc)

[Induced Collections](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/induced) and [Latency modes](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/latency)

### Unmanaged Resources

[Cleaning up unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)

[Dispose pattern](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose) and [Object.Finalize method](https://docs.microsoft.com/en-us/dotnet/api/system.object.finalize#remarks)

[Weak References](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/weak-references)

[Memory and Span usage guidelines](https://docs.microsoft.com/en-us/dotnet/standard/memory-and-spans/memory-t-usage-guidelines)

## Asynchronous Programming

[Asynchronous programming patterns](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/)

### Task-based Asynchronous Pattern (TAP)

[Task-based asynchronous pattern](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap)

[Task asynchronous programming model](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/task-asynchronous-programming-model)

[Asynchronous programming scenarios](https://docs.microsoft.com/en-us/dotnet/csharp/async)

#### Async / Await

[Asynchronous programming with async and await](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/)

[Async in depth](https://docs.microsoft.com/en-us/dotnet/standard/async-in-depth)

[Stephen Cleary: Async and Await](https://blog.stephencleary.com/2012/02/async-and-await.html)

[Stephen Cleary: There Is No Thread](https://blog.stephencleary.com/2013/11/there-is-no-thread.html)

##### Async / Await Correct Usage

[Don't Block on Async Code](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html)

[Eliding Async and Await](https://blog.stephencleary.com/2016/12/eliding-async-await.html)

[ConfigureAwait FAQ](https://devblogs.microsoft.com/dotnet/configureawait-faq/)

#### Cancellation of asynchronous operations

[Task cancellation](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-cancellation)

[Cancellation in Managed Threads](https://docs.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads)

#### Interop with other asynchronous patterns

[Interop with Other Asynchronous Patterns and Types](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/interop-with-other-asynchronous-patterns-and-types)

[The Nature of TaskCompletionSource](https://devblogs.microsoft.com/pfxteam/the-nature-of-taskcompletionsourcetresult/)

### Event-based Asynchronous Pattern (EAP)

[Event-based Asynchronous Pattern Overview](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/event-based-asynchronous-pattern-overview)

### Asynchronous Programming Model (APM)

[Asynchronous Programming Model](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/asynchronous-programming-model-apm)

## Parallel Programming

[Parallel Programming in .NET](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/)

### Task Scheduler

[Task Scheduler in .NET](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskscheduler#remarks)

### Data Synchronization

[Synchronizing data for multithreading](https://docs.microsoft.com/en-us/dotnet/standard/threading/synchronizing-data-for-multithreading)

#### Synchronization Context

[It's All About the SynchronizationContext](https://docs.microsoft.com/en-us/archive/msdn-magazine/2011/february/msdn-magazine-parallel-computing-it-s-all-about-the-synchronizationcontext)

[ASP.NET Core SynchronizationContext](https://blog.stephencleary.com/2017/03/aspnetcore-synchronization-context.html)

#### Synchronization mechanisms

[Synchronization primitives](https://docs.microsoft.com/en-us/dotnet/standard/threading/overview-of-synchronization-primitives)

[Thread-Safe Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/)

[lock statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement)

[volatile](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile)

#### Async Coordination Primitives

[AsyncManualResetEvent](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-1-asyncmanualresetevent/)

[AsyncAutoResetEvent](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-2-asyncautoresetevent/)

[AsyncCountdownEvent](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-3-asynccountdownevent/)

[AsyncBarrier](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-4-asyncbarrier/)

[AsyncSemaphore](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-5-asyncsemaphore/)

[AsyncLock](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-6-asynclock/)

[AsyncReaderWriterLock](https://devblogs.microsoft.com/pfxteam/building-async-coordination-primitives-part-7-asyncreaderwriterlock/)

## LINQ

[Introduction to LINQ Queries](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)

[Query expression basics](https://docs.microsoft.com/en-us/dotnet/csharp/linq/query-expression-basics)

## Other

### .NET & C# features

[Access Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)

[Boxing and Unboxing](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)

[Intrincis attribute](https://stackoverflow.com/questions/56388664/what-does-the-intrinsic-attribute-in-c-sharp-do)

### Type System

[Covariance and contravariance](https://docs.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance)

[Delegates VS Events](https://docs.microsoft.com/en-us/dotnet/csharp/distinguish-delegates-events)

[Hashtable and Dictionary Collection Types](https://docs.microsoft.com/en-us/dotnet/standard/collections/hashtable-and-dictionary-collection-types)

[DateTime VS DateTimeOffset](./datetime-vs-datetimeoffset/README.md)

### Closure

[Closure internals](http://sergeyteplyakov.blogspot.com/2010/04/c.html)

[Замыкания на переменных цикла в C# 5](https://habr.com/ru/post/141270/)

## Resources

[.NET](https://docs.microsoft.com/en-us/dotnet/fundamentals/) & [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) official documentation

[.NET Blog](https://devblogs.microsoft.com/dotnet/)

Stephen Cleary [Blog](https://blog.stephencleary.com/)

Sergey Teplyakov [Blog](https://sergeyteplyakov.blogspot.com/)