using PedidosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using PedidosExercicio.Entities;

namespace PedidosExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente : ");
            Console.Write("Nome : ");
            string cliente = Console.ReadLine();
            
            Console.Write("Email : ");
            string email = Console.ReadLine();
            
            Console.Write("Data de nascimento (DD/MM/YYYY) : ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o status do pedido (AguardandoPagamento/Processando/Enviado/Entregue) : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente client = new Cliente(cliente, email, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, client);

            Console.Write("Quantos itens irão para este pedido? : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} produto : " );
                Console.Write("Nome do produto : ");
                string produtoNome = Console.ReadLine();
                Console.Write("Entre com o preço do produto : ");
                double preco = double.Parse(Console.ReadLine());

                Produtos produto = new Produtos(produtoNome, preco);

                Console.Write("Quantidade : ");
                int quantidade = int.Parse(Console.ReadLine());

                PedidoItem item = new PedidoItem(quantidade, preco, produto);

                pedido.AddItem(item);
                Console.WriteLine();


            }

            Console.WriteLine();
            Console.WriteLine("Resumo do pedido : ");
            Console.WriteLine(pedido);

        }
    }
}
