using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wiederholung17022022.Models;

namespace Wiederholung17022022
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EssensRepository rep = new EssensRepository();
        public MainWindow()
        {
            InitializeComponent();

            var donnerstag = new Donnerstag()
            { Inhalt = "Ein Text", Markiert = true, Farbe = "Green" };
            donnerstag.HeutigeMenues = rep.GetAllEssen("Donnerstag");
            /*
            donnerstag.HeutigeMenues = new ObservableCollection<Essen>()
            {
                new Essen(){Bezeichnung="Döner", Preis=4.5},
                new Essen(){Bezeichnung="Suppe", Preis=3.7}
            }; 
            */


            this.DataContext = donnerstag;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string uhrzeit = System.DateTime.Now.ToLongTimeString();

            var myCastDonnerstag = this.DataContext as Donnerstag;
            myCastDonnerstag.Inhalt = uhrzeit;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var myCastDonnerstag = this.DataContext as Donnerstag;
            myCastDonnerstag.HeutigeMenues.Add(
                new EssenProTag() { Bezeichnung = "Salatschüssel", Preis = 8.5 }
                );
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var myCastDonnerstag = this.DataContext as Donnerstag;
            myCastDonnerstag.EventAusloesen();
        }

        private void DBInitialisierne_Click(object sender, RoutedEventArgs e)
        {

            var myCastDonnerstag = this.DataContext as Donnerstag;
            MyEssensContext ctx = new MyEssensContext();
            foreach (var menue in myCastDonnerstag.HeutigeMenues)
            {
                EssenProTag essenProTag = new EssenProTag();
                essenProTag.Tag = "Donnerstag";
                essenProTag.Bezeichnung = menue.Bezeichnung;
                essenProTag.Preis = menue.Preis;
                ctx.Essensliste.Add(essenProTag);
            }

            ctx.SaveChanges();
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            rep.UpdateEssen();
        }

        private void EssenHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            EssenProTag neu = new EssenProTag() { Bezeichnung = "Wiener Schnitzel", Preis = 9.5, Tag = "Donnerstag" };
            var myCastDonnerstag = this.DataContext as Donnerstag;
            myCastDonnerstag.HeutigeMenues.Add(neu);
            rep.AddEssen(neu);
        }

    }
}
