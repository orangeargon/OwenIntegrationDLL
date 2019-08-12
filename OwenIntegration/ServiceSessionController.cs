using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class ServiceSessionController
    {
        public List<ServiceSession> sessions;

        public void startSession(IObserver client, IRequest request)
        {
            ServiceSession = new ServiceSession();
        }
    }
}
