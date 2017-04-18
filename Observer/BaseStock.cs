using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    class BaseStock:Stock 
    {
        public BaseStock(string Name,double Price):base(Name, Price)
        {

        }
    }
}
