using System;
using System.Collections.Generic;
using System.Text;

namespace OwenIntegration
{
    public interface IObserver
    {
        void next(Request response);
        void error(Request response);
        void complete(Request response);
    }
}
