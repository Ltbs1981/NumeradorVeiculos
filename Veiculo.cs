using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeradoresVeiculo
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public Motor Motor { get; set; }

        public Veiculo(string marca, string modelo, int ano, TipoVeiculo tipo, Motor motor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Tipo = tipo;
            Motor = motor;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine(Motor.ObterDetalhes());
        }
    }
}
