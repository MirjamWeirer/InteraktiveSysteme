using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung17022022.Models
{
    internal class MyEssensContext: DbContext
    {
        public DbSet<EssenProTag> Essensliste { get; set; }
    }
}
