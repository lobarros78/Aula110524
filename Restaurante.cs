using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1105
{
    public class Restaurante
    {
        public List<Pedido> pedidos = new List<Pedido>();
        public Dictionary<int, List<Pedido>> pedidosPorMesa = new Dictionary<int, List<Pedido>>();

        public double CalcularTotalMesa(int mesa)
        {
            double total = 0;
            if (pedidosPorMesa.ContainsKey(mesa))
            {
                foreach (var pedido in pedidosPorMesa[mesa])
                {
                    total += pedido.CalcularTotal();
                }
                return total;

            }
            else
            {
                return 0;
            }

        }

        public void AdicionarPedido(int mesa, Pedido pedido)
        {
            if (pedidosPorMesa.ContainsKey(mesa))
            {
                pedidosPorMesa[mesa].Add(pedido);
            }
            else
            {
                List<Pedido> lista = new List<Pedido>();
                lista.Add(pedido);
                pedidosPorMesa.Add(mesa, lista);
            }
        }
        public void ModificarPedido(int mesa, int indicePedido, Pedido novoPedido)
        {
            if (pedidosPorMesa.ContainsKey(mesa))
            {
                pedidosPorMesa[mesa][indicePedido] = novoPedido;
            }
        }
    }
}