using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesellschaftsspiele.Model
{
   public class GesellschaftsspielRepository
    {
        private GesellschaftsspielContext ctx = new GesellschaftsspielContext();

        public Gesellschaftsspiel GetById(int id)
        {
            return ctx.Gesellschaftsspiele.Find(id);
        }

        public ObservableCollection<Gesellschaftsspiel> GetByKategorie(string kategorie)
        {
            ObservableCollection<Gesellschaftsspiel> result =
                new ObservableCollection<Gesellschaftsspiel>();

            foreach (var spiel in ctx.Gesellschaftsspiele.Where(s => s.Kategorie == kategorie))
            {
                result.Add(spiel);
            }

            return result;


        }

        public ObservableCollection<Gesellschaftsspiel> GetAll()
        {
            ObservableCollection<Gesellschaftsspiel> result =
                new ObservableCollection<Gesellschaftsspiel>();

            foreach (var spiel in ctx.Gesellschaftsspiele)
            {
                result.Add(spiel);
            }

            return result;
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void AddSpiel(Gesellschaftsspiel spiel)
        {
            ctx.Gesellschaftsspiele.Add(spiel);
            Save();
        }

        public void RemoveSpiel(Gesellschaftsspiel spiel)
        {
            ctx.Gesellschaftsspiele.Remove(spiel);
            Save();
        }
    }
}
