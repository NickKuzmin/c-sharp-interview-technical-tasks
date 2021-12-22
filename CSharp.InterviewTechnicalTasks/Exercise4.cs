using System;

namespace CSharp.InterviewTechnicalTasks.Exercise4
{
    public class Program
    {
        public class A<T>
        {
            public static int Count { get; set; }
            public A() { Count++; }
        }

        public static void Internal(string[] args)
        {
            // var A1 = new A<object>();
            var A2 = new A<string>();
            var A3 = new A<int>();
            Console.WriteLine(A<object>.Count); // 1
        }
    } 
}
