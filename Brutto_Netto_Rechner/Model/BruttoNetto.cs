using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutto_Netto_Rechner.Model
{
    internal class BruttoNetto : INotifyPropertyChanged
    {
        private double _Netto;
        public double Netto { get { return _Netto; } set { _Netto = value; calc(); RaiseChangedEvent("Netto"); } }

        private double _Brutto;
        public double Brutto 
        { 
            get { return _Brutto; } 
            set { _Brutto = value; calc(); RaiseChangedEvent("Brutto"); } 
        }

        private string _Produktart;
        public string Produktart { get { return _Produktart; } set { _Produktart = value; calc(); RaiseChangedEvent("Produktart"); } }

        private double _Steuerbetrag;
        public double Steuerbetrag { get { return _Steuerbetrag; } set { _Steuerbetrag = value; calc(); RaiseChangedEvent("Steuerbetrag"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        private void calc()
        {
            switch (Produktart)
            {
                case "Lebensmittel":
                    _Steuerbetrag = 0.10;
                    _Brutto = _Netto + (_Netto * _Steuerbetrag);
                    break;
                case "Luxusgut":
                    _Steuerbetrag = 0.20;
                    _Brutto = _Netto + (_Netto * _Steuerbetrag);
                    break;
                default:
                    _Steuerbetrag = 0;
                    _Brutto = _Netto + (_Netto * _Steuerbetrag);
                    break;
            }
        }
    }
}
