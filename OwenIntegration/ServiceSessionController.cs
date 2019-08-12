using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class ServiceSessionController
    {
        public List<ServiceSession> sessions;
        public ServiceSessionFactory sessionFactory;
        public ServiceBus serviceBus;
        public string endpointId;

        public ServiceSessionController(string _endpointId, ServiceBus _serviceBus, ServiceSessionFactory _sessionFactory)
        {
            sessionFactory = _sessionFactory;
            serviceBus = _serviceBus;
            endpointId = _endpointId;
            serviceBus.listen(endpointId, new CrudServer() /*TODO*/);
        }

        public void startSession(Observer client, Request request)
        {
            ServiceSession a = new ServiceSession(new Request);
        }
    }
}
