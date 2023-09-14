using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // For measuring execution time
using System.Xml.Linq;

namespace RequestsQueue
{
    public static class Technical_Support

    {
        public static PriorityQueue priorityQueue = new PriorityQueue();

       
        public static void AddRequest(int number, string name, string description, int urgencyLevel) //Enqueue
        {
            Request aux_request = new Request(number, name,description, urgencyLevel);

            priorityQueue.Enqueue(aux_request);
        }

        public static void AttendToRequests()// Dequeue  //void?
        {
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine("Request Attended"); 
        }

        public static void ShowRequests() // void? 
        {
            List<Request> orderedQueue = priorityQueue.GetOrderedQueue();

            // Printing ordered queue
            foreach (var request in orderedQueue)
            {
                Console.WriteLine(request);
                //Console.WriteLine($"Solicitud #{request.requestNumber}: {request.customerName} - Urgencia: {request.urgencyLevel}");
            }
        }

        public static void UpdateUrgencyLevel(int requestNumberToUpdate, int newUrgencyLevel)
        {
            

            // Buscar la solicitud en la cola por su número de solicitud
            Request requestToUpdate = null;
            foreach (var request in priorityQueue.GetOrderedQueue())
            {
                if (request.requestNumber == requestNumberToUpdate)
                {
                    requestToUpdate = request;
                    break;
                }
            }

            if (requestToUpdate != null)
            {
                Console.WriteLine($"Current urgency level of request #{requestToUpdate.requestNumber}: {requestToUpdate.urgencyLevel}");
                
                // Actualizar el nivel de urgencia de la solicitud
                requestToUpdate.urgencyLevel = newUrgencyLevel;

                Console.WriteLine($"Urgency level of request #{requestToUpdate.requestNumber} updated to {newUrgencyLevel}");
            }
            else
            {
                Console.WriteLine($"Request #{requestNumberToUpdate} not found in the queue.");
            }
        }

    }
}
