using System;
using System.Collections.Generic;
using System.Diagnostics; // For measuring execution time
namespace RequestsQueue
{

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Menu.ChooseOptionMenu(4);

            stopwatch.Stop();

           

            
            Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} milliseconds");
        }
    }
}