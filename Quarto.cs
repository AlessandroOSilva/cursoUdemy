using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelDeQuartos
{
    class Quarto
    {
        public int Numero { get; set; }
        public string Inquilino { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return (Numero +
                ": " + 
                Inquilino
                + ", " + 
                Email);
        }
    }
}
