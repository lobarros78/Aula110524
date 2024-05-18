using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1105
{
    public class Pedido
    {
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Pedido(string item, int qtde, double valor)
        {
            Item = item;
            Quantidade = qtde;
            Preco = valor;
        }

        public double CalcularTotal()
        {
            return (Quantidade * Preco);
        }
    }
}