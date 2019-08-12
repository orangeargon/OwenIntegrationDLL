using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public interface ICrudServer
    {
        void create(Request request);
        void read(Request request);
        void update(Request request);
        void delete(Request request);
    }
}
