using System;
using System.Collections.Generic;
using System.Text;
using enums_1.entities.enums;

namespace enums_1.entities
{
    class pedidos
    {
        public int NumeroPedido { get; set; }
        public string Item { get; set; }
        public estadoPedido PedidoStatus { get; set; }

        public DateTime  HoraPedido { get; set; }

        public itens ItemPedido { get; set; }

        public int preco { get; set; }




        public override string ToString()
        {
            return

            "id pedido" + NumeroPedido +
            "item " + Item +
            "status pedido " + PedidoStatus +
            "Data " + HoraPedido +
            "valor " + preco;
        }
    }
}
