using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Seconds => 10s = 10 seconds");
            Console.WriteLine("M - Minutes => 1m = 1 minute");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("How much time do you want to count?");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Time is up!");
            Thread.Sleep(2500);
        }
    }
}