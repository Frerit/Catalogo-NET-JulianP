using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Procedimientos
    {
        public int Restar(int valorA, int valorB)
        {
            if (valorA > 0)
                return valorA - valorB;
           
            return (valorA) - valorB;

        }

        public int Multiplicar(int valorA, int valorB)
        {
            if (valorB == 0 || valorA == 0)
                return 0;

            else if((valorB % 2) == 0)
                return -1;

            return valorA * valorB;
        }

    }
}
