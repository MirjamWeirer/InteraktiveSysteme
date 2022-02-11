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
using Brutto_Netto_Rechner.Model;

namespace Brutto_Netto_Rechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BruttoNetto bruttoNetto = new BruttoNetto();
            bruttoNetto.Netto = 100;
            bruttoNetto.Brutto = bruttoNetto.Netto + bruttoNetto.Steuerbetrag;
            bruttoNetto.Produktart = "Lebensmittel";
            bruttoNetto.Steuerbetrag = 0;

            this.DataContext = bruttoNetto;
        }
    }
}
