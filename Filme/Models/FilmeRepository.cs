using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Models
{
    internal class FilmeRepository
    {
        private MyFilmeContext ctx = new MyFilmeContext();
        
        public ObservableCollection<FilmeProTag> GetAllFilme(string tag)
        {
            ObservableCollection<FilmeProTag> result = new ObservableCollection<FilmeProTag>();

            foreach (var film in ctx.Filmliste.Where(e=>e.Tag == tag))
            {
                result.Add(film);
            }
            return result;
        }

        public void UpdateFilme()
        {
            ctx.SaveChanges ();
        }

        public void AddFilme(FilmeProTag neuerFilm)
        {
            ctx.Filmliste.Add(neuerFilm);
            ctx.SaveChanges();
        }
    }
}
