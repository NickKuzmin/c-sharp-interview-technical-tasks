using System;

namespace CSharp.InterviewTechnicalTasks.Exercise5
{
    public class Bus
    {
        static int RouteNumber { get; set; }

        static Bus()
        {
            RouteNumber = 1;
        }

        public Bus(int routeNum)
        {
            if (RouteNumber == 1)
            {
                RouteNumber = routeNum;
                Console.WriteLine("Bus #{0} is created.", RouteNumber);
            }
        }

        public void Drive()
        {
            Console.WriteLine("Bus #{0} drive.", RouteNumber);
        }
    }

    public class Program
    {
        public static void Internal(string[] args)
        {
            Bus bus1 = new Bus(71); // 71
            Bus bus2 = new Bus(72); // 71

            bus1.Drive(); // 71
            bus2.Drive(); // 71
        }
    } 
}
