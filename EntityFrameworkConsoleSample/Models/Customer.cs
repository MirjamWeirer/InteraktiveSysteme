using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleSample.Models
{
    internal class Customer
    {
        //Primary Key --- ClassId
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public int Lastname { get; set; }
        public bool Points { get; set; }

    }
}
