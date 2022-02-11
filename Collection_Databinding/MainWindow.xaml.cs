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
using Collection_Databinding.Model;

namespace Collection_Databinding
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bücherei bücherei = null;
        public MainWindow()
        {
            InitializeComponent();

            bücherei = new Bücherei();

            this.DataContext = bücherei;
        }

        private void Neu(object sender, RoutedEventArgs e)
        {
            Buch b = new Buch() { Titel = "Steirerwahn", Autor = "Claudia Rossbacher", ISBAN = "978-3-8392-0198-5", Preis = 18.00, Ausgeliehen = false, Farbe = "Red" };
            bücherei.Bücher.Add(b);
        }
    }
}
