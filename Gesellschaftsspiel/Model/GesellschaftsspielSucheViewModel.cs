using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesellschaftsspiele.Model
{
    public class GesellschaftsspielSucheViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Gesellschaftsspiel> _GesellschaftspieleGefunden;
        private GesellschaftsspielRepository rep = new GesellschaftsspielRepository();

        public ObservableCollection<Gesellschaftsspiel> GesellschaftspieleGefunden
        {
            get { return _GesellschaftspieleGefunden; }
            set { _GesellschaftspieleGefunden = value; }
        }

        private string _Suchtext;
        public string Suchtext
        {
            get { return _Suchtext; }
            set { 
                    _Suchtext = value;
                    GesellschaftspieleGefunden = rep.GetBySuchstring(_Suchtext);
                    RaiseEvent("StatusAnzeige");
                 RaiseEvent("GesellschaftspieleGefunden");
            }
        }
      

        private string _StatusAnzeige;

        public string StatusAnzeige
        {
            get { return "Momentan sind " + GesellschaftspieleGefunden.Count + " Elemente in der Liste"; }

        }

        


        private void RaiseEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
