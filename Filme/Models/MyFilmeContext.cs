using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Models
{
    internal class MyFilmeContext: DbContext
    {
        public DbSet<FilmeProTag> Filmliste { get; set; }
    }
}
