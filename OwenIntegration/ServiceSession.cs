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
        public ServiceSession(string _type, string _id, string _status, string _payload)
        {
            request.type = _type;
            request.id = _id;
            request.status = _status;
            request.payload = _payload;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="status">Статус сессии</param>
        /// <param name="payload">Запрос</param>
        public ServiceSession(string _id, string _status, string _payload)
        {
            request.type = "request";
            request.id = _id;
            request.status = _status;
            request.payload = _payload;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="payload">Запрос</param>
        public ServiceSession(string _id, string _payload)
        {
            request.type = "request";
            request.id = _id;
            request.status = RequestStatus.New;
            request.payload = _payload;
        }

        /// <summary>
        /// </summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        /// <param name="_request">Экземпляр запроса</param>
        public ServiceSession(string _id, Request _request)
        {
            request = _request;
            request.id = _id;
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Идентификатор сессии</param>
        public ServiceSession(string _id)
        {
            request.type = "request";
            request.id = _id;
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
