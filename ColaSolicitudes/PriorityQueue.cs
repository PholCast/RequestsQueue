using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RequestsQueue
{
    public class PriorityQueue
    {
        private List<Request> requests;

        public PriorityQueue()
        {
            requests = new List<Request>();
        }

        public void Enqueue(Request request)
        {
            int index = 0;

            // Buscar la posición correcta para insertar el elemento según la urgencia
            while (index < requests.Count && request.urgencyLevel <= requests[index].urgencyLevel)
            {
                index++;
            }

            // Insertar el elemento en la posición encontrada
            requests.Insert(index, request);
        }

        public Request Dequeue()
        {
            if (requests.Count == 0)
            {
                throw new InvalidOperationException("La cola de prioridad está vacía");
            }

            Request topPriorityRequest = requests[0];
            requests.RemoveAt(0);
            return topPriorityRequest;
        }

        public List<Request> GetOrderedQueue()
        {
            // Devuelve una copia ordenada de la cola sin eliminar los elementos originales
            List<Request> orderedQueue = new List<Request>(requests);
            return orderedQueue;
        }

        public int Count
        {
            get { return requests.Count; }
        }
    }
}