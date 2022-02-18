using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesellschaftsspiele.Model
{
    class GesellschaftsspielContext : DbContext
    {
        public DbSet<Gesellschaftsspiel> Gesellschaftsspiele { get; set; }
    }
}
