using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class ServiceSessionFactory
    {
        public ServiceSession create(IRequest request)
        {
            ServiceSession test = new ServiceSession();
            return test;
        }
    }
}
