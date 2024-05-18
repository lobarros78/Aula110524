using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1105
{
    public class Cozinha
    {
        public Queue<Pedido> filaDePedidos = new Queue<Pedido>();
        public Stack<Pedido> pilhaDePedidosProntos = new Stack<Pedido>();

        public void AdicionarPedidoNaFila(Pedido pedido)
        {
            filaDePedidos.Enqueue(pedido);
        }
        public void ProcessarPedido()
        {
            if (filaDePedidos.Count > 0)
            {
                pilhaDePedidosProntos.Push(filaDePedidos.Peek());
                filaDePedidos.Dequeue();
            }
        }
        public void EntregarPedido()
        {
            if (pilhaDePedidosProntos.Count > 0)
            {
                pilhaDePedidosProntos.Pop();
            }
        }
    }
}