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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        int hoch = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            hoch++;
            this.Title = "Wert von X " + hoch;
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = Convert.ToInt32(lblNumber.Content.ToString()) + 1;
        }
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = Convert.ToInt32(lblNumber.Content.ToString()) - 1;
        }
    }
}
