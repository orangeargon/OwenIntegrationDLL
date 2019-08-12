using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class ServiceSessionFactory
    {
        public SessionIdProvider sessionIdProvider;

        public ServiceSessionFactory(SessionIdProvider _sessionIdProvider)
        {
            sessionIdProvider = _sessionIdProvider;
        }
        public ServiceSession create(Request request)
        {
            ServiceSession RabbitSession = new ServiceSession(sessionIdProvider.getNewId(), request);
            return RabbitSession;
        }
    }
}
