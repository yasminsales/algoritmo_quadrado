using System;
using System.Collections.Generic;
using System.Text;

namespace console_quadrado
{
    class Quadrado
    { 
        public int Valor { get; set; }

        public int ComParametro(int valor)
        {
            return valor * valor; 
        }

        public int SemParametro()
        {
            return Valor * Valor;
        }
    }
}
