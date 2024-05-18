using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1105
{
    public class SistemaDeAnaliseDeVendas
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Venda> vendas = new List<Venda>();

        public void FiltrarVendasPorData(DateTime dataIni, DateTime dataFim)
        {
            //List<string> vendasPorData = new();
            if (vendas.Count > 0)
            {
                var vendasPorData = vendas.Where(p => p.Data >= dataIni && p.Data <= dataFim);
                foreach (var lista in vendasPorData)
                {
                    Console.WriteLine(lista.ToString());

                }

            }
        }
        public void ListarProdutosVendidos()
        {
            List<string> listaProdVendido = new();
            foreach (var lista in vendas)
            {


            }
        }
    }
}