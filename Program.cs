using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var stopwatch = new Stopwatch();
                Console.Write("Press enter to start: ");
                stopwatch.Start();

                Console.Write("Press enter to stop: ");
                stopwatch.Stop();

                Console.WriteLine("Your duration is " + stopwatch.Caclulate());
            }
        }
    }
}
