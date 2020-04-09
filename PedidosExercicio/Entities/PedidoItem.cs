using PedidosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosExercicio.Entities
{
    class PedidoItem
    {
        public int Quantity { get; set; }
        public double Preco { get; set; }
        public Produtos Produto { get; set; }


        public PedidoItem() { }

        public PedidoItem(int quantity, double preco, Produtos produto)
        {
            Quantity = quantity;
            Preco = preco;
            Produto = produto;

        }

        public double SubTotal()
        {
            return Preco * Quantity;
        }

        public override string ToString()
        {
            return $"{Produto.Nome}, R${Preco:f2}, Quantidade : {Quantity}, total : R$ {SubTotal()}";
        }
    }
}
