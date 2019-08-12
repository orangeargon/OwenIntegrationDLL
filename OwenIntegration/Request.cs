using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public class Request : IRequest
    {
        public string type = "request";
        public string id;
        public string status = RequestStatus.New;
        public string payload;
    }
}
