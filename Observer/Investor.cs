using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns.Observer
{
    class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock Member)
        {
            MessageBox.Show("Notified to " + _name + " for " + Member.Symbol + " changed to " + Member.Price);
        }
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
