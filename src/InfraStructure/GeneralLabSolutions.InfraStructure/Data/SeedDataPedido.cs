using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GeneralLabSolutions.InfraStructure.Data
{
    public static class SeedDataPedido
    {
        public static StatusDoPedido GetStatusDoPedidoByWeight(Random random)
        {
            var pesos = new Dictionary<StatusDoPedido, int>
            {
                { StatusDoPedido.Orcamento, 10 },   // Peso maior que cancelado
                { StatusDoPedido.EmProcessamento, 20 },  // Peso ainda maior
                { StatusDoPedido.Pago, 30 },        // Peso mais alto (prioritário)
                { StatusDoPedido.Enviado, 10 },     // Peso médio
                { StatusDoPedido.Entregue, 20 },    // Peso grande
                { StatusDoPedido.Cancelado, 5 }     // Peso mínimo (raridade)
            };

            // Calcular a soma total dos pesos
            int pesoTotal = pesos.Values.Sum();

            // Gerar um número aleatório no intervalo de 0 até pesoTotal - 1
            int randomValue = random.Next(0, pesoTotal);

            // Percorrer os pesos e retornar o status correspondente
            int acumulado = 0;
            foreach (var entry in pesos)
            {
                acumulado += entry.Value;
                if (randomValue < acumulado)
                {
                    return entry.Key;
                }
            }

            // Fallback (apenas como segurança, mas nunca deverá acontecer)
            return StatusDoPedido.Pago;
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context == null || context.Pedido == null || context.ItemPedido == null || context.Cliente == null || context.Vendedor == null || context.Produto == null)
                {
                    throw new ArgumentNullException("Null AppDbContext");
                }

                if (!context.Pedido.Any())
                {
                    var random = new Random();
                    var clientes = context.Cliente.ToList();
                    var vendedores = context.Vendedor.ToList();
                    var produtos = context.Produto.ToList();

                    // Adiciona a lógica para gerar pedidos nos anos 2022, 2023 e 2024
                    // Itera pelos anos 2022, 2023 e 2024
                    for (int ano = 2022; ano <= 2024; ano++)
                    {
                        for (int mes = 1; mes <= 12; mes++) // Itera pelos 12 meses do ano
                        {
                            int numPedidos = random.Next(6, 16); // 6 a 15 pedidos por mês

                            for (int i = 0; i < numPedidos; i++)
                            {
                                var cliente = clientes [random.Next(clientes.Count)];
                                var vendedor = vendedores [random.Next(vendedores.Count)];

                                // Obtém o número de dias no mês
                                int diasNoMes = DateTime.DaysInMonth(ano, mes);

                                // Aumenta o limite para o último dia
                                var dataPedido = new DateTime(ano, mes, random.Next(1, diasNoMes + 1));

                                var pedido = new Pedido(cliente.Id, vendedor.Id, dataPedido)
                                {
                                    StatusDoPedido = GetStatusDoPedidoByWeight(random)
                                };

                                int numItens = random.Next(2, 7); // 2 a 6 itens por pedido
                                for (int j = 0; j < numItens; j++)
                                {
                                    var produto = produtos [random.Next(produtos.Count)];

                                    // Até 3 quantidades de Ítens por Pedido
                                    var quantidade = random.Next(1, 4);

                                    var itemPedido = new ItemPedido(
                                        pedidoId: pedido.Id,
                                        produtoId: produto.Id,
                                        quantidade: quantidade,
                                        valorUnitario: produto.ValorUnitario,
                                        nomeDoProduto: produto.Descricao // Obter o NomeDoProduto do Produto
                                    );

                                    pedido.AdicionarItem(itemPedido);
                                }

                                context.Pedido.Add(pedido);
                            }
                        }
                    }

                    context.SaveChanges();
                    Console.WriteLine("SeedData para Pedido e ItemPedido gerado com sucesso!");
                } else
                {
                    Console.WriteLine("O SeedData para Pedido e ItemPedido já foi gerado!");
                }
            }
        }
    }
}