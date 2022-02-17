using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Models
{
    internal class FilmeProTag : INotifyPropertyChanged
    {
        public int FilmeProTagId { get; set; }

        private string _Tag;
        public string Tag
        {
            get { return _Tag; }
            set { _Tag = value; RaiseChangedEvent("Tag"); }
        }

        private string _Titel;
        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; RaiseChangedEvent("Titel"); }
        }

        private double _Ticketpreis;
        public double Ticketpreis { 
            get { return _Ticketpreis; } 
            set { _Ticketpreis = value; RaiseChangedEvent("Ticketpreis"); }
        }

        private int _LängeInMinuten;

        public event PropertyChangedEventHandler PropertyChanged;

        public int LängeInMinuten
        {
            get { return _LängeInMinuten;}
            set { _LängeInMinuten = value; RaiseChangedEvent("LängeInMinuten"); }
        }

        private void RaiseChangedEvent(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
