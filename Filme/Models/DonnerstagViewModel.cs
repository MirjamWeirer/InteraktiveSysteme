using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Models
{
    internal class DonnerstagViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<FilmeProTag> HeutigeFilme { get; set; }
        private FilmeProTag _AktuelleAuswahl;
        public FilmeProTag AkutelleAuswahl
        {
            get { return _AktuelleAuswahl; }
            set { _AktuelleAuswahl = value; RaiseChangedEvent("IhreAuswahl"); }
        }
        public string IhreAuswahl
        {
            get
            {
                if (AkutelleAuswahl != null)
                    return "Sie haben " + AkutelleAuswahl.Titel + " (" + AkutelleAuswahl.FilmeProTagId + ") ausgewählt";
                else
                {
                    return "Sie haben noch nicht ausgwählt";
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseChangedEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public void EventAusloesen()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Titel"));
        }
    }
}
