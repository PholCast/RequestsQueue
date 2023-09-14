using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RequestsQueue
{
    public static class Test
    {
        public static List<String> StringDataRequests = FileHandling.ReadFile("C:\\Users\\pholc\\Source\\Repos\\RequestsQueue\\ColaSolicitudes\\data.txt");

        public static void testCode(int numberOfRequests)
        {
         
            
            PriorityQueue queueTest = new PriorityQueue();

            Stopwatch enqueueStopwatch = new Stopwatch(); // Cronómetro para medir el encolado
            enqueueStopwatch.Start();

            for (int i = 0; i < numberOfRequests; i++)
            {

                string[] dataRequest = StringDataRequests[i].Split(',');

                Request newRequest = new Request(Convert.ToInt32(dataRequest[0]), dataRequest[1], dataRequest[2], Convert.ToInt32(dataRequest[3]));

                
                queueTest.Enqueue(newRequest);

                Console.WriteLine(i+". ENQUEUING..." + newRequest);
            }
            enqueueStopwatch.Stop();
            long enqueueTimeMilli = enqueueStopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time Enqueuing {numberOfRequests} elements: {enqueueTimeMilli} Milliseconds");

            Stopwatch dequeueStopwatch = new Stopwatch();
            dequeueStopwatch.Start();

            for (int i = 0; i < numberOfRequests; i++)
            {

                Request dequeueRequest = queueTest.Dequeue();

                Console.WriteLine(i + ". DEQUEUING..." + dequeueRequest);
            }
            dequeueStopwatch.Stop();
            long dequeueTimeMilli = dequeueStopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time Dequeuing {numberOfRequests} elements: {dequeueTimeMilli} Milliseconds");
        }


    }
}
