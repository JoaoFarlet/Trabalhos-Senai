using System;
using enums_1.entities;
using enums_1.entities.enums;

namespace enums_1
{
    class Program
    {
        static void Main(string[] args)
        {
            pedidos pedido = new pedidos();

            Console.WriteLine("insira o item do Pedido");
            int intemval = int.Parse(Console.ReadLine());
            pedido.ItemPedido = (itens)intemval;

            Console.WriteLine("insira o Numero do Pedido");
            pedido.NumeroPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o Estado do Pedido:");
            int estPed = int.Parse(Console.ReadLine());
            pedido.PedidoStatus = (estadoPedido) estPed;

            pedido.preco = intemval;

            pedido.HoraPedido = DateTime.Now;

            Console.WriteLine(pedido);


        }
    }
    }
