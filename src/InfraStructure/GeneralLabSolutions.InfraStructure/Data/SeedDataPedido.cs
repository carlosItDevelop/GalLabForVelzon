using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneralLabSolutions.InfraStructure.Data
{
    public static class SeedDataPedido
    {
        // Método para obter um StatusDoItem aleatório com base em pesos (agora buscamos da tabela StatusDoItem)
        public static StatusDoItem GetStatusDoItemByWeight(Random random, List<StatusDoItem> statusItens)
        {
            // Aqui você pode definir os pesos para cada StatusDoItem, se desejar
            // Exemplo:
            var pesos = new Dictionary<string, int>
            {
                { "Pago", 30 },
                { "Entregue", 20 },
                { "Aguardando a Transportadora", 5 },
                { "Em Revisao", 8 },
                { "Em Transito", 10 },
                { "Na Alfândega", 15 },
                // ... outros status e seus pesos
            };

            // Se você não quiser usar pesos, pode remover essa parte e fazer um random simples

            int pesoTotal = pesos.Values.Sum();
            int randomValue = random.Next(0, pesoTotal);
            int acumulado = 0;

            foreach (var status in statusItens)
            {
                if (pesos.ContainsKey(status.Descricao))
                {
                    acumulado += pesos [status.Descricao];
                    if (randomValue < acumulado)
                    {
                        return status;
                    }
                }
            }

            // Fallback: retorna um status aleatório da lista (caso os pesos não estejam definidos para todos os status)
            return statusItens [random.Next(statusItens.Count)];
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

                    // *** Buscar os StatusDoItem do banco de dados ***
                    var statusItens = context.StatusDoItem.ToList();

                    // Adiciona a lógica para gerar pedidos nos anos 2022, 2023 e 2024
                    for (int ano = 2022; ano <= 2024; ano++)
                    {
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            int numPedidos = random.Next(6, 16);

                            for (int i = 0; i < numPedidos; i++)
                            {
                                var cliente = clientes [random.Next(clientes.Count)];
                                var vendedor = vendedores [random.Next(vendedores.Count)];
                                var dataPedido = new DateTime(ano, mes, random.Next(1, DateTime.DaysInMonth(ano, mes) + 1));

                                var pedido = new Pedido(cliente.Id, vendedor.Id, dataPedido);
                                pedido.AtualizarStatus(StatusDoPedido.Orcamento);




                                int numItens = random.Next(2, 7);
                                for (int j = 0; j < numItens; j++)
                                {
                                    var produto = produtos [random.Next(produtos.Count)];
                                    var quantidade = random.Next(1, 4);

                                    var itemPedido = new ItemPedido(
                                        pedidoId: pedido.Id,
                                        produtoId: produto.Id,
                                        quantidade: quantidade,
                                        valorUnitario: produto.ValorUnitario,
                                        nomeDoProduto: produto.Descricao
                                    );

                                    // *** Obter um StatusDoItem aleatório com base nos pesos ***
                                    var statusDoItem = GetStatusDoItemByWeight(random, statusItens);

                                    // *** Criar um novo EstadoDoItem associando ao ItemPedido e ao StatusDoItem ***
                                    var estadoDoItem = new EstadoDoItem(itemPedido.Id, statusDoItem.Id);
                                    itemPedido.Estados.Add(estadoDoItem); // Adiciona o estado ao item

                                    pedido.AdicionarItem(itemPedido);
                                }

                                context.Pedido.Add(pedido);
                            }
                        }
                    }

                    // context.SaveChanges(); // Removido o SaveChanges daqui e colocado no DbInitializer (UMA ÚNICA TRANSAÇÃO)
                    Console.WriteLine("SeedData para Pedido, ItemPedido e EstadoDoItem gerado com sucesso!");
                } else
                {
                    Console.WriteLine("O SeedData para Pedido, ItemPedido e EstadoDoItem já foi gerado!");
                }
            }
        }
    }
}