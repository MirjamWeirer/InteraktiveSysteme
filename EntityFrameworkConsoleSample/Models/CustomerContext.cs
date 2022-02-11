﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleSample.Models
{
    internal class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
