using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    abstract class Subject
    {
        public abstract void Request(string Value);
    }
}
