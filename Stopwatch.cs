using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }

        public void Start()
        {
            for (int i = 0; i < 1; i++)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) == true)
                {
                    startTime = DateTime.Now;
                }
                else
                {
                    Console.Write("Invalid input please press enter to start: ");
                    i--;
                    continue;
                }
            }
            Console.Clear();
        }
        public void Stop()
        {
            for (int i = 0; i < 1; i++)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) == true)
                {
                    stopTime = DateTime.Now;
                }
                else
                {
                    Console.Write("Invalid input please press enter to stop: ");
                    i--;
                    continue;
                }
            }
            Console.Clear();
        }
        public TimeSpan Caclulate()
        {
            return stopTime - startTime;
        }
    }
}
