using System;
using System.Collections.Generic;
using System.Diagnostics; // For measuring execution time
namespace RequestsQueue
{

    class Program
    {
        static void Main(string[] args)
        {

            List<String> StringDataRequests = FileHandling.ReadFile("C:\\Users\\avira\\source\\repos\\RequestsQueue\\ColaSolicitudes\\data.txt");



           Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Menu.ChooseOptionMenu();

            stopwatch.Stop();

           

            
            Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} milliseconds");
        }
    }
}