using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp
{
    internal class Program
    {
        delegate int MethodenAdesseAufIntInt(int a, int b);
        static void Main(string[] args)
        {
            Math m = new Math();
            int result;
            result = m.AddNumbers(3, 4);
            MethodenAdesseAufIntInt adr = m.AddNumbers;
            result = m.SubNumbers(8, 2);

            adr = m.SubNumbers;

            Rechnen(5, 10, m.AddNumbers);
            Rechnen(9, 3, m.SubNumbers);

            //Lambda => (u,v) fließt nach / in
            Rechnen(5, 7, (u, v) => u * v);
        }


        static void Rechnen(int x, int y, MethodenAdesseAufIntInt logik)
        {
            var ergebnis = logik(x, y);
        }
    }

    class Math
    {
        public int AddNumbers(int z1, int z2)
        {
            return z1 + z2;
        }

        public int SubNumbers(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}
