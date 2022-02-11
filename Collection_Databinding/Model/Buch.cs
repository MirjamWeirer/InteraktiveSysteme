using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Collection_Databinding.Model
{
    internal class Buch : INotifyPropertyChanged
    {
        private string _Titel;
        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; RaisePropertyChangedEvent("Titel"); }
        }

        private string _Autor;
        public string Autor { get { return _Autor; } set { _Autor = value; RaisePropertyChangedEvent("Autor"); } }

        private string _ISBAN;
        public string ISBAN { get { return _ISBAN; } set { _ISBAN = value; RaisePropertyChangedEvent("ISBAN"); } }

        private double _Preis;
        public double Preis { get { return _Preis; } set { _Preis = value; RaisePropertyChangedEvent("Preis"); } }

        public bool Ausgeliehen { get; set; }

        private string _Farbe;

        public string Farbe
        {
            get { return _Farbe; }
            set { _Farbe = value; RaisePropertyChangedEvent("Farbe"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return "Titel: " + Titel;
        }
    }
}
