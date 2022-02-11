using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Collection_Databinding.Model
{
    internal class Bücherei: INotifyPropertyChanged
    {
        public ObservableCollection<Buch> Bücher { get; set; }

        public Bücherei()
        {
            Bücher = new ObservableCollection<Buch>()
            {
                new Buch() { Titel = "Letzter Stollen", Autor = "Herbert Dutzler", ISBAN = "978-3-7099-7910-5", Preis = 12.95, Ausgeliehen = true, Farbe = "Red" },
            new Buch() { Titel = "Letzter Jodler", Autor = "Herbert Dutzler", ISBAN = "978-3-7099-7915-0", Preis = 14.95, Ausgeliehen = false, Farbe = "Red" },
            new Buch()
            {
                Titel = "Johanna Dohnal und die Frauenpolitik der Zweiten Republik",
                Autor = "Alexandra Weiss, Erika Thuner",
                ISBAN = "978-3-85371-454-6",
                Preis = 25.00,
                Ausgeliehen = true,
                Farbe = "Green"
            },
            new Buch() { Titel = "Feministin sagt man nicht", Autor = "Hanna Herbst", ISBAN = "978-3-7106-0194-1", Preis = 20.00, Ausgeliehen = false, Farbe = "Green" },
        };   
        }
        private Buch _AusgewähltesBuch;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Sichtbar
        {
            get { return (AusgewähltesBuch == null) ? "hidden" : "visible"; }

        }

        public Buch AusgewähltesBuch
        {
            get { return _AusgewähltesBuch; }
            set 
            { 
                _AusgewähltesBuch = value;
                RaisePropertyChangedEvent("AusgewähltesBuch");
                RaisePropertyChangedEvent("Sichtbar");
            }
        }

        private void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
