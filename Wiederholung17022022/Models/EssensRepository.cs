using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung17022022.Models
{
    //CRUD - Create Read Update Delete
    internal class EssensRepository
    {
        private MyEssensContext ctx = new MyEssensContext();

        public ObservableCollection<EssenProTag> GetAllEssen(string tag)
        {
            ObservableCollection<EssenProTag> result = new ObservableCollection<EssenProTag>();


            foreach (var essen in ctx.Essensliste.Where(e => e.Tag == tag))
            {
                result.Add(essen);
            }
            return result;
        }

        public void UpdateEssen()
        {
            ctx.SaveChanges();
        }

        public void AddEssen(EssenProTag neuesEssen)
        {
            ctx.Essensliste.Add(neuesEssen);
            ctx.SaveChanges();
        }
    }
}
