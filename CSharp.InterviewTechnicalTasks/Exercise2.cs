using System;

namespace CSharp.InterviewTechnicalTasks.Exercise2
{
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }

    public class Program
    {
        public static void Internal(string[] args)
        {
            var s = new S();
            using (s)
            {
                Console.WriteLine(s.GetDispose());
            }
            Console.WriteLine(s.GetDispose());
        }
    } 
}
