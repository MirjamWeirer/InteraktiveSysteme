using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorWithDataBinding.Model
{
    internal class Calculator
    {
        private int _Zahl1;
        public int Zahl1
        {
            get { return _Zahl1; }
            set { _Zahl1 = value; }
        }
        private int _Zahl2;
        public int Zahl2
        {
            get { return _Zahl1; }
            set { _Zahl1 = value; }
        }

        private string _Mathoperator;
        
        public string Mathoperator
        {
            get { return _Mathoperator; }
            set { _Mathoperator = value; }
        }

        private int _Ergebnis;
        public int Eergebnis
        {
            get { return _Ergebnis; }
            set { _Ergebnis = value; }
        }

        private void calc()
        {
            //switch (_Mathoperator)
            //{
            //    case "+"
            //        _Ergebnis = Zahl1 + Zahl2;
            //    case "-":
            //         _Ergebnis = Zahl1 + Zahl2;
            //    case "*":
            //         _Ergebnis = Zahl1 + Zahl2;
            //    case "/":
            //         _Ergebnis = Zahl1 + Zahl2;
            //}
        }
    }
}
