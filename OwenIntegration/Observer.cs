using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class Observer : IObserver
    {
        /// <summary>
        /// </summary>
        /// <param name="response">Запрос</param>
        public void next(Request response)
        {

        }

        /// <summary>
        /// </summary>
        /// <param name="response">Запрос</param>
        public void error(Request response)
        {

        }

        /// <summary>
        /// </summary>
        /// <param name="response">Запрос</param>
        public void complete(Request response)
        {

        }
    }
}
