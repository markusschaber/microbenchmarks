 // This file is considered simple enough by the author to be not copyrightable.

 using BenchmarkDotNet.Running;

 namespace CharInStringOrArray
 {
     public static class Program
     {
         public static void Main(string[] args)
         {
             var summary = BenchmarkRunner.Run<ActorPath>(null, args);
         }
     }
 }
