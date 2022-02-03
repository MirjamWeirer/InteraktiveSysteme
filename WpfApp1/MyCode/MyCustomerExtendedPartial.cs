using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.MyCode
{
    public partial class Customer
    {
        public int Age { get; set; }

        private int _MyProperty;
        public int MyProperty 
        { 
            get 
            { 
                return _MyProperty;
            }
            set
            {
                _MyProperty = value;
            }
        }
    }
}
