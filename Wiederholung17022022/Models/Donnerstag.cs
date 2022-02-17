using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung17022022.Models
{
    internal class Donnerstag: INotifyPropertyChanged
    {
        // public string Inhalt { get; set; }

        //public List<Essen> HeutigeMenues{ get; set; }

        public ObservableCollection<EssenProTag> HeutigeMenues { get; set; }


        private EssenProTag _AktuellAusgewaehlt;

        public EssenProTag AktuellAusgewaehlt
        {
            get { return _AktuellAusgewaehlt; }
            set
            {
                _AktuellAusgewaehlt = value;
                FireChangeEvent("AktuellAusgewaehlt");
                FireChangeEvent("IhreAuswahl");

            }
        }


        public string IhreAuswahl
        {
            get
            {
                if (AktuellAusgewaehlt != null)
                    return "Sie haben " + AktuellAusgewaehlt.Bezeichnung + "(" + AktuellAusgewaehlt.EssenProTagId + ") ausgewähl";
                else
                    return "Sie haben noch nicht ausgewählt";
            }

        }


        private string _Inhalt;

        public string Inhalt
        {
            get { return _Inhalt; }
            set
            {
                _Inhalt = value;
                FireChangeEvent("Inhalt");

            }
        }

        private bool _Markiert;

        public bool Markiert
        {
            get { return _Markiert; }
            set
            {
                _Markiert = value;
                FireChangeEvent("Markiert");
            }
        }

        private string _Farbe;

        public string Farbe
        {
            get { return _Farbe; }
            set
            {
                _Farbe = value;
                FireChangeEvent("Farbe");
            }
        }


        private void FireChangeEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public void EventAusloesen()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Inhalt"));
                //GUI fragt getter von Inhalt ab
            }
        }
        //Interface INotifyPropertyChanged  fordert PropertyChanged-Event
        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
