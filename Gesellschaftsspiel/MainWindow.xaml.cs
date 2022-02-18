using Gesellschaftsspiele.Model;
using System;
using System.Collections.Generic;
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
using Gesellschaftsspiele.Model;


namespace Gesellschaftsspiele
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new GesellschaftsspielViewModel();

            this.DataContext = vm;

        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            GesellschaftsspielViewModel vm = this.DataContext as GesellschaftsspielViewModel;
            vm.Speichern();
        }

        private void NeuesSpiel_Click(object sender, RoutedEventArgs e)
        {
            
            /*
            Gesellschaftsspiel neuesSpiel = new Gesellschaftsspiel();
            neuesSpiel.Titel = "Ein Demo";
            neuesSpiel.MaxAnzahlSpieler = 7;
            neuesSpiel.Kategorie = "Test";
            GesellschaftsspielViewModel vm = this.DataContext as GesellschaftsspielViewModel;
            vm.AddSpiel(neuesSpiel);
            */
            NeuesGesellschaftsspiel newSpielWindow = new NeuesGesellschaftsspiel();

            Gesellschaftsspiel neuesSpiel = new Gesellschaftsspiel();
            //neuesSpiel.Titel = "Bitte eingeben";
            //neuesSpiel.Kategorie = "Bitte Kat eingeben";
            newSpielWindow.DataContext = neuesSpiel;

            newSpielWindow.ShowDialog();//Wartet auf schließen des neuen Fensters
            GesellschaftsspielViewModel vm = this.DataContext as GesellschaftsspielViewModel;
            vm.AddSpiel(neuesSpiel);
        }

        private void Loeschen_Click(object sender, RoutedEventArgs e)
        {
            GesellschaftsspielViewModel vm = this.DataContext as GesellschaftsspielViewModel;
            vm.RemoveSpiel(vm.Ausgewaehltesspiel);
        }

        private void Suchen_Click(object sender, RoutedEventArgs e)
        {
            GesellschaftsspielSucheViewModel sucheVM = this.DataContext as GesellschaftsspielSucheViewModel;
            Suchwindow suchwindow = new Suchwindow();
            suchwindow.DataContext = sucheVM;
            suchwindow.ShowDialog();
        }
    }
}
