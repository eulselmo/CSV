[LINQ](Linq/)
* **exampleLinq.cs** - Example to calculate the average marks of diferents students 
in differents countries 

 The syntax is similar to the one in SQL, but with the advantage that we have the power of .net and visual studio when coding. With lambda, we can directly call functions where, join, select, directly from the object.


  ![example linq](Linq/exampleLinq.jpg)

[NORMAL VS PARALLEL LOOP](NormalVSParallelLoop/)
* **normalVSparallelloop.cs** - Example about how much faster is parallel loop than the normal 
version

 Parallel.For and normal For loop both share the similar syntax, but the parallel loop runs faster on a computer that has available cores. Another difference is that, unlike a sequential loop, the order of execution isn't defined for a parallel loop. Steps often take place at the same time, in parallel.


  ![example normal vs parallel loop](NormalVSParallelLoop/normalVSparallelloop.jpg)

[PERFECT NUMBERS](PerfectNumbers/)
* **perfectNumberwithParallel.cs** - Perfect Numbers using parallel for
  Can improve performance a lot by parallelizing your code, but it also has overhead (synchronization between threads, invoking the delegate on each iteration).


* **perfectNumberwithThreads.cs** - Perfect Numbers using differents threads
 The task is more abstract than the threads. It is created in the subprocess group that already has threads created by the system to improve performance.Tasks are usually created in the subprocess group and they are treated as background subprocesses.


[USES WITH THREADS](UseswithThreads/)
* **createThreads.cs** - Creation of differents threads
 Thread is a light weight process which helps in running the tasks in parallel. The threads works independently and provides the maximum utilization of the CPU, thus enhancing the CPU performance.

* **threadsJoin.cs** - Creation of threads using join
 The join method causes the Thread from where that method is invoked, to be blocked until the thread invoked ends.
