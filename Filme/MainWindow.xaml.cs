using Filme.Models;
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

namespace Filme
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FilmeRepository rep = new FilmeRepository();
        public MainWindow()
        {
            InitializeComponent();
            var donnerstag = new DonnerstagViewModel();
            //donnerstag.HeutigeFilme = new ObservableCollection<FilmeProTag>()
            //{
            //    new FilmeProTag(){Titel = "Harray Potter und der Stein der Weisen", LängeInMinuten=90, Tag="Donnerstag",Ticketpreis=7.5},
            //new FilmeProTag() { Titel = "Encanto", LängeInMinuten = 111, Ticketpreis = 8, Tag = "Donnerstag" }
            //};
            donnerstag.HeutigeFilme = rep.GetAllFilme("Donnerstag");
            this.DataContext = donnerstag;
        }
        public void Neu(object sender, RoutedEventArgs e)
        {
            var myCastDonnerstag = this.DataContext as DonnerstagViewModel;
            myCastDonnerstag.HeutigeFilme.Add(
                new FilmeProTag() { Titel = "Die Dohnal", Ticketpreis = 8.5, LängeInMinuten = 145, Tag = "Donnerstag" }
                );
        }


        private void FilmeHinzufuegen(object sender, RoutedEventArgs e)
        {
            FilmeProTag neu = new FilmeProTag() { Titel = "Die göttliche Ordnung", Ticketpreis = 5, Tag = "Donnerstag", LängeInMinuten = 120 };
            var myCastDonnestag = this.DataContext as DonnerstagViewModel;
            myCastDonnestag.HeutigeFilme.Add(neu);
            rep.AddFilme(neu);
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            rep.UpdateFilme();
        }

        private void DBInitalisieren(object sender, RoutedEventArgs e)
        {
            var myCastDonnerstag = this.DataContext as DonnerstagViewModel;
            MyFilmeContext ctx = new MyFilmeContext();
            foreach (var filme in myCastDonnerstag.HeutigeFilme)
            {
                FilmeProTag filmeProTag = new FilmeProTag();
                filmeProTag.Tag = "Donnerstag";
                filmeProTag.Titel = filme.Titel;
                filmeProTag.Ticketpreis = filme.Ticketpreis;
                filmeProTag.LängeInMinuten = filme.LängeInMinuten;
                ctx.Filmliste.Add(filmeProTag);
            }

            ctx.SaveChanges();
        }

        private void EventSimulieren(object sender, RoutedEventArgs e)
        {
            var myCastDonnerstag = this.DataContext as DonnerstagViewModel;
            myCastDonnerstag.EventAusloesen();
        }
    }
}
