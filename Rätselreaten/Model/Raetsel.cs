using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rätselreaten.Model
{
    internal class Raetsel
    {
        string[] fragen = { "Hauptstadt Ö", "Kontinente", "Anzahl Planeten", "Erfinder der Glühbirne", "Esssen Vegtarisch Fleisch" };
        string[] antwort = { "Wien", "7", "8,5", "Edisson", "Nein" };

        private int _AnzahlRichtig;
        private int _AnzahlFalsch;
        private int _Counter;
        private string _AktuelleFrage;
        private string _Statusanzeige;
        private string _AktuelleAntwort;

        public int AnzahlRichtig
        {
            get { return _AnzahlRichtig;}
            set { _AnzahlRichtig = (int)value; }
        }

        public int AnzahlFalsch
        {
            get { return _AnzahlFalsch; }
            set { _AnzahlFalsch = (int)value; }
        }
        public int Counter
        {
            get { return _Counter; }
            set { _Counter = (int)value; }
        }

        public string AktuelleFrage
        {
            get { return _AktuelleFrage; }
            
        }
        public string AktuelleAntwort
        {
            get { return _AktuelleAntwort; }
            
        }
    }
}
