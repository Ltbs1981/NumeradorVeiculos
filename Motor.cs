using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeradoresVeiculo
{
    public class Motor
    {
        public string Fabricante { get; set; }
        public int Potencia { get; set; }

        public Motor(string fabricante, int potencia)
        {
            Fabricante = fabricante;
            Potencia = potencia;
        }

        public string ObterDetalhes()
        {
            return $"Fabricante do Motor: {Fabricante}, Potência: {Potencia} CV";
        }
    }
}
