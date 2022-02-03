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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MyStarterWindow : Window
    {
        public MyStarterWindow()
        {
            InitializeComponent();
            StackPanel myPanel = new StackPanel();
            Button myButton = new Button();
            myButton.Content = "Hello World";
            myPanel.Children.Add(myButton);
            this.AddChild(myPanel);
        }

    }   
}
