using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class ServiceSession
    {
        //Fields
        Request request;

        //Constructors
        /// <summary>
        /// </summary>
        /// <param name="type">Тип сессии</param>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="status">Статус сессии</param>
        /// <param name="payload">Запрос</param>
        public ServiceSession(string type, string id, string status, string payload)
        {
            request.type = type;
            request.id = id;
            request.status = status;
            request.payload = payload;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="status">Статус сессии</param>
        /// <param name="payload">Запрос</param>
        public ServiceSession(string id, string status, string payload)
        {
            request.type = "request";
            request.id = id;
            request.status = status;
            request.payload = payload;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="payload">Запрос</param>
        public ServiceSession(string id, string payload)
        {
            request.type = "request";
            request.id = id;
            request.status = RequestStatus.New;
            request.payload = payload;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        public ServiceSession(string id)
        {
            request.type = "request";
            request.id = id;
            request.status = RequestStatus.New;
            request.payload = "";
        }

        /// <summary>
        /// </summary>
        /// <param name="_request">Экземпляр запроса</param>
        public ServiceSession(Request _request)
        {
            request = _request;
        }

        //Methods
        public ServiceSession getRequest()
        {
            return this;
        }

        public void update(Request requestUpdate)
        {
            if (requestUpdate.status != null)
                request.status = requestUpdate.status;
            if (requestUpdate.payload != null)
                request.payload = requestUpdate.payload;

            switch (request.status)
            {
                case RequestStatus.Error:
                    Observable.notifyError(request);
                    break;
                case RequestStatus.Complete:
                    Observable.notifyComplete(request);
                    break;
                default:
                    Observable.notifyNext(request);
                    break;
            }
        }
    }
}
