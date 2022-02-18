using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesellschaftsspiele.Model
{
    public class GesellschaftsspielViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Gesellschaftsspiel> _Gesellschaftspiele;
        private GesellschaftsspielRepository rep = new GesellschaftsspielRepository();

        public ObservableCollection<Gesellschaftsspiel> Gesellschaftspiele
        {
            get { return _Gesellschaftspiele; }
            set { _Gesellschaftspiele = value; }
        }

        public GesellschaftsspielViewModel()
        {
            Gesellschaftspiele = rep.GetAll();
        }

        public void Speichern()
        {
            rep.Save();
        }

        public void AddSpiel(Gesellschaftsspiel spiel)
        {
            //GUI
            Gesellschaftspiele.Add(spiel);
            //DB
            rep.AddSpiel(spiel);

            RaiseEvent("StatusAnzeige");
        }

        public void RemoveSpiel(Gesellschaftsspiel spiel)
        {
            //GUI
            Gesellschaftspiele.Remove(spiel);
            //DB
            rep.RemoveSpiel(spiel);

            RaiseEvent("StatusAnzeige");
        }

        private string _StatusAnzeige;

        public string StatusAnzeige
        {
            get { return "Momentan sind " + Gesellschaftspiele.Count + " Elemente in der Liste"; }

        }

        private Gesellschaftsspiel _Ausgewaehltesspiel;


        public Gesellschaftsspiel Ausgewaehltesspiel
        {
            get { return _Ausgewaehltesspiel; }
            set { _Ausgewaehltesspiel = value; RaiseEvent("Ausgewaehltesspiel"); }
        }



        private void RaiseEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
