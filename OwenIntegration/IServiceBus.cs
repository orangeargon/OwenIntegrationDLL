using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public interface IServiceBus
    {
        void send(string endpoint, Request request);
        void listen(string endpoint, CrudServer server);
    }
}
