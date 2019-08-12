using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public static class Observable
    {
        public static List<Observer> Observers;

        /// <summary>
        /// </summary>
        /// <param name="observer">Observer</param>
        public static void subscribe(Observer observer)
        {
            Observers.Add(observer);
        }

        /// <summary>
        /// </summary>
        /// <param name="observer">Запрос</param>
        public static void notifyNext(Request data)
        {
            foreach(Observer observer in Observers)
            {
                observer.next(data);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="observer">Запрос</param>
        public static void notifyError(Request err)
        {
            foreach (Observer observer in Observers)
            {
                observer.error(err);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="observer">Запрос</param>
        public static void notifyComplete(Request data)
        {
            foreach (Observer observer in Observers)
            {
                observer.complete(data);
            }
        }
    }
}
