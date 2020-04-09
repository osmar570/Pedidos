using PedidosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosExercicio.Entities
{
    class Pedido
    {
        public DateTime Moment { get; set; }
        OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>();


        public Pedido() { }

        public Pedido(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(PedidoItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(PedidoItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment : {Moment:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine($"Order status : {Status}");
            sb.AppendLine($"Cliente : {Cliente.Nome}");
            sb.AppendLine($"Itens do pedido : ");
            foreach(PedidoItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Preço total é de R${Total()}");
            return sb.ToString();
        }

    }
}
