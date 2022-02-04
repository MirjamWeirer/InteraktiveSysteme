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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int merkZahl1()
        {
            int z1 = int.Parse(Zahl.Text);
            return z1;
        }
        private int merkZahl2()
        {
            int z2 = int.Parse(Zahl.Text);
            return z2;
        }

        private string berechnung(string berechnug = null)
        {
            return berechnug;
        }


        private void Button_Addition(object sender, RoutedEventArgs e) 
        {
            Button addition = (Button)sender;
            //addition = (Button)addition.Content;
            //berechnung(addition.ToString());
            double z1 = Convert.ToDouble(Zahl.Text);
            double z2 = Convert.ToDouble(Zahl2.Text);
            double ergebnis = z1 + z2;
            Ergebnis.Text = ergebnis.ToString();
        }

        private void Button_Subbtraktion(object sender, RoutedEventArgs e)
        {
            Button sub = (Button)sender;
            double z1 = Convert.ToDouble(Zahl.Text);
            double z2 = Convert.ToDouble(Zahl2.Text);
            double ergebnis = z1 - z2;
            Ergebnis.Text = ergebnis.ToString();
        }

        private void Button_Division(object sender, RoutedEventArgs e)
        {
            Button div = (Button)sender;
            double z1 = Convert.ToDouble(Zahl.Text);
            double z2 = Convert.ToDouble(Zahl2.Text);
            if (z2 == 0)
            {
                Zahl.Text = "Error";
            }
            double ergebnis = z1 / z2;
            Ergebnis.Text = ergebnis.ToString();
        }

        private void Button_Multiplikation(object sender, RoutedEventArgs e)
        {
            Button mal = (Button)sender;
            double z1 = Convert.ToDouble(Zahl.Text);
            double z2 = Convert.ToDouble(Zahl2.Text);
            double ergebnis = z1 * z2;
            Ergebnis.Text = ergebnis.ToString();
        }

        private void _0(object sender, RoutedEventArgs e)
        {
            string z = "0";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
           
        }

        private void _1(object sender, RoutedEventArgs e)
        {
            string z = "1";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _2(object sender, RoutedEventArgs e)
        {
            string z = "2";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _3(object sender, RoutedEventArgs e)
        {
            string z = "3";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _4(object sender, RoutedEventArgs e)
        {
            string z = "4";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _5(object sender, RoutedEventArgs e)
        {
            string z = "5";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _6(object sender, RoutedEventArgs e)
        {
            string z = "6";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _7(object sender, RoutedEventArgs e)
        {
            string z = "7";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _8(object sender, RoutedEventArgs e)
        {
            string z = "8";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void _9(object sender, RoutedEventArgs e)
        {
            string z = "9";
            if (Zahl.Text != z && String.IsNullOrEmpty(Zahl.Text))
            {
                Zahl.Text = z;
            }
            else
            {
                Zahl2.Text = z;
            }
        }

        private void C(object sender, RoutedEventArgs e)
        {
            Zahl.Text = "";
            Zahl2.Text = "";
            Ergebnis.Text = "0";
        }
    }
}
