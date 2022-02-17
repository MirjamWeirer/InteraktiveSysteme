using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung17022022.Models
{
    internal class EssenProTag : INotifyPropertyChanged
    {
        //Primary-Key
        public int EssenProTagId { get; set; }
        private String _Tag;
        public String Tag
        {
            get { return _Tag; }
            set { _Tag = value; RaiseChangedEvent("Tag"); }
        }
        private string _Bezeichnung;

        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set { _Bezeichnung = value; RaiseChangedEvent("Bezeichnung"); }
        }

        private double _Preis;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Preis
        {
            get { return _Preis; }
            set { _Preis = value; RaiseChangedEvent("Preis"); }
        }

        private void RaiseChangedEvent(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
