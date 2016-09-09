using System.Collections.Generic;

namespace Nardax
{
    public static class QueueExtensions
    {

        //en Funktion där man kan lägga till en lista
        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }


    }
}