using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Start crono1 and stop for 0.5 seconds
            crono1.Start();
            Thread.Sleep(500);

            // Start crono2 and stop for 0.3 seconds
            crono2.Start();
            Thread.Sleep(300);

            // Stop cronos
            crono1.Stop();
            crono2.Stop();

            // Print time;
            Console.WriteLine($"Crono 1: {+crono1.Elapsed.TotalSeconds:f2} seconds.");
            Console.WriteLine($"Crono 2: {+crono2.Elapsed.TotalSeconds:f2} seconds.");
        }
    }
}
