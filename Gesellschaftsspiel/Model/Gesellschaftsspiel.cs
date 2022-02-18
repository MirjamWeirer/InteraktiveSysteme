using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesellschaftsspiele.Model
{
    //Entity-Klasse
   public class Gesellschaftsspiel : INotifyPropertyChanged
    {
        public int GesellschaftsspielId { get; set; }

        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; RaiseEvent("Titel"); }
        }

        private int _MaxAnzahlSpieler;

        public int MaxAnzahlSpieler
        {
            get { return _MaxAnzahlSpieler; }
            set { _MaxAnzahlSpieler = value; RaiseEvent("MaxAnzahlSpieler"); }
        }

        private string _Bild;

        public string Bild
        {
            get { return _Bild; }
            set { _Bild = value; RaiseEvent("Bild"); }
        }

        private string _Kategorie;

        public string Kategorie
        {
            get { return _Kategorie; }
            set { _Kategorie = value; RaiseEvent("Kategorie"); }
        }



        private void RaiseEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
