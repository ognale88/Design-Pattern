using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class ProxySubject : Subject
    {
        private RealSubject _realSubject;
        public override void Request(string Value)
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();
            _realSubject.Request(Value);
        }
    }
}
