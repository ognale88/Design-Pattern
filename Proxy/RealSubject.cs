using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns.Proxy
{
    class RealSubject : Subject
    {
        public override void Request(string Value)
        {
            MessageBox.Show("Called Request method in RealSubject Class Value : "+ Value,"Real Subject Class");
        }
    }
}
